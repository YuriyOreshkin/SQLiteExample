using SQLiteExample.UI.Model;
using SQLiteExample.UI.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace SQLiteExample.UI.Category
{
    public partial class CategoriesFormList : Telerik.WinControls.UI.RadForm
    {
        private IRepository repository;

        public CategoriesFormList(IRepository _repository)
        {
            InitializeComponent();
            repository= _repository;

        }

        private void commandBarButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       public void commandBarButtonEdit_Click(object sender, EventArgs e)
        {
            if (radGridViewCategories.SelectedRows.Count > 0)
            {
                var selected = radGridViewCategories.SelectedRows[0].DataBoundItem as Model.Category;

                CategoriesFormEdit child = new CategoriesFormEdit(selected);
                child.Text = "Изменение записи";

                child.ThemeName = this.ThemeName;

                if (child.ShowDialog() == DialogResult.OK)
                {
                   
                    repository.categories.Update(selected);
                };
            }
        }

        public void radGridViewRow_Select(object sender, EventArgs e)
        {
            if (radGridViewCategories.SelectedRows.Count > 0)
            {
                this.DialogResult=DialogResult.OK;
            }
        }

        private void commandBarButtonAdd_Click(object sender, EventArgs e)
        {
            var add = new Model.Category();

            CategoriesFormEdit child = new CategoriesFormEdit(add);
            child.Text = "Добавление записи";

            child.ThemeName = this.ThemeName;

            if (child.ShowDialog() == DialogResult.OK)
            {
                repository.categories.Create(add);
               
            };

        }

        private void commandBarButtonDelete_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this,"Вы уверены в том, что желаете удалить данную запись?","Внимание!",MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                var selected = radGridViewCategories.SelectedRows[0].DataBoundItem as Model.Category;

                repository.categories.Delete(selected);
            }
        }

        private void CategoriesFormList_Load(object sender, EventArgs e)
        {
            
            radGridViewCategories.DataSource = repository.categories.ToBindingList();

            radGridViewCategories.Columns["code"].Width = 50;

            radGridViewCategories.Columns["id"].IsVisible = false;

            //Disable column filtering
            radGridViewCategories.Columns["code"].AllowFiltering = false;
        }


        private void radMenuItemExportItem_Click(object sender, EventArgs e)
        {
           
            switch (((Telerik.WinControls.UI.RadMenuItem)sender).Tag)
            {
                case "0":
                    RunExportCommand(ExportType.Excel, "Excel (*.xls)|*.xls");
                    break;
                case "1":
                    RunExportCommand(ExportType.CSV, "CSV File (*.csv)|*.csv");
                    break;
                case "2":
                    RunExportCommand(ExportType.PDF, "PDF File (*.pdf)|*.pdf");
                    break;
                case "3":
                    RunExportCommand(ExportType.HTML, "Html File (*.html)|*.html");
                    break;
            }
            
        }


        private void RunExportCommand(ExportType type,string filter)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (saveFileDialog.FileName.Equals(String.Empty))
            {
                RadMessageBox.SetThemeName(this.radGridViewCategories.ThemeName);
                RadMessageBox.Show("Пожалуйста, укажите имя файла.");
                return;
            }

            string fileName = saveFileDialog.FileName;
           
            try
            {
                RunExport(type, fileName);
                RadMessageBox.SetThemeName(this.radGridViewCategories.ThemeName);
                DialogResult dr = RadMessageBox.Show("Экспорт выполнен успешно! Открыть файл?", "Экспорт", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                    catch (Exception ex)
                    {
                        string message = String.Format("Файл не может быть открыт.\nОшибка: {0}", ex.Message); RadMessageBox.Show(message, "Открыть файл", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridViewCategories.ThemeName); RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);

            }

        }

        private void RunExport(ExportType type,string filename)
        {
            switch (type)
            {
                case ExportType.Excel:
                    ExportToExcelML excelExporter = new ExportToExcelML(this.radGridViewCategories);
                    excelExporter.RunExport(filename);
                    break;

                case ExportType.CSV:
                    ExportToCSV csvExporter = new ExportToCSV(this.radGridViewCategories);
                    csvExporter.RunExport(filename);
                    break;

                case ExportType.HTML:
                    ExportToHTML htmlExporter = new ExportToHTML(this.radGridViewCategories);
                    //set exporting visual settings             
                    htmlExporter.ExportVisualSettings = true;
                    htmlExporter.TableCaption = "Категории";
                    htmlExporter.RunExport(filename);
                    break;

                case ExportType.PDF:
                    ExportToPDF pdfExporter = new ExportToPDF(this.radGridViewCategories);
                    //pdfExporter.PdfExportSettings.Title = "My PDF Title";
                    pdfExporter.PdfExportSettings.PageWidth = 297;
                    pdfExporter.PdfExportSettings.PageHeight = 210;
                    //pdfExporter.PageTitle = "Категории";
                    pdfExporter.FitToPageWidth = true;
                    pdfExporter.RunExport(filename);
                    break;

            }
        }

        private void radGridViewCategories_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = radContextMenuCategories.DropDown;
        }

        private void commandBarButtonPrint_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radGridViewCategories.ThemeName;
            dialog.Document = this.radPrintDocumentCategories;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }

        private void radGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            ProductsFormList ProductForm = Application.OpenForms.OfType<ProductsFormList>().FirstOrDefault();
            if (ProductForm != null)
            {
                if (radGridViewCategories.SelectedRows.Count > 0)
                {
                    var selected = radGridViewCategories.SelectedRows[0].DataBoundItem as Model.Category;
                    ProductForm.radDropDownListCategories.SelectedValue = selected.id;
                }
            } 
                    
        }
    }


    enum ExportType
    {
        Excel,
        CSV,
        HTML,
        PDF,
    }
}
