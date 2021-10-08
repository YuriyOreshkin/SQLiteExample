using SQLiteExample.UI.Category;
using SQLiteExample.UI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Telerik.ReportViewer.WinForms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;


namespace SQLiteExample.UI.Product
{
    public partial class ProductsFormList : Telerik.WinControls.UI.RadForm
    {
        private IRepository repository;
        public ProductsFormList(IRepository _repository)
        {
            InitializeComponent();
            repository = _repository;

            DownListCategories_SetDataSource();

        }

        private void ProductsFormList_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplyThemeToControlTree(this, this.ThemeName);


            SetDataSource();
           
        }

        private void  SetDataSource()
        {
            radGridViewProducts.DataSource = repository.products.ToBindingList();

            radGridViewProducts.Columns["price"].MaxWidth = 200;
            radGridViewProducts.Columns["date"].MaxWidth = 200;
            radGridViewProducts.Columns["instock"].MaxWidth = 200;
            radGridViewProducts.Columns["unitsinstock"].MaxWidth = 200;

            radGridViewProducts.Columns["id"].IsVisible = false;

            radGridViewProducts.Columns["date"].FormatString = "{0:dd.MM.yyyy}";

            radGridViewProducts.Columns["price"].FormatString = "{0:c}";

            radGridViewProducts.Columns["categoryid"].IsVisible = false;
            radGridViewProducts.Columns["category"].IsVisible = false;
        }


        private void radButtonSelectCategory_Click(object sender, EventArgs e)
        {
            CategoriesFormList child = new CategoriesFormList(repository);
            child.ThemeName = this.ThemeName;
            
            child.radGridViewCategories.DoubleClick += new System.EventHandler(child.radGridViewRow_Select);

            if (child.ShowDialog() == DialogResult.OK)
            {
                var selected = child.radGridViewCategories.SelectedRows[0].DataBoundItem as Model.Category;
                radDropDownListCategories.DataSource = null;
                DownListCategories_SetDataSource();
                radDropDownListCategories.SelectedValue = selected.id;
            };
        }

        private void DownListCategories_SetDataSource()
        {
            radDropDownListCategories.ValueMember = "id";
            radDropDownListCategories.DisplayMember = "name";

            List<Model.Category> dropdownlist = new List<Model.Category>();
            dropdownlist.Add(new Model.Category { id = 0, name = "Все категории" });

            foreach (Model.Category category in repository.categories.Get()) 
            {
                dropdownlist.Add(category);
            }
            
            radDropDownListCategories.DataSource = dropdownlist;
            
        }

        private void commandBarButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radDropDownListCategories_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
            if (radGridViewProducts.FilterDescriptors.Count > 0)
            {
                for (int i = 0; i < radGridViewProducts.FilterDescriptors.Count; i++)
                {
                    if (radGridViewProducts.FilterDescriptors[i].PropertyName == "categoryid")
                    {
                        radGridViewProducts.FilterDescriptors.RemoveAt(i);
                    }
                }
            }
            
            if (this.radDropDownListCategories.SelectedIndex > -1)
            {
                var id = ((RadDropDownList)sender).SelectedItem.Value; //as Model.Category;
                if ((long)id == 0)
                {
                    return;
                }
                else
                {

                    FilterDescriptor filter = new FilterDescriptor();
                    filter.PropertyName = "categoryid";
                    filter.Operator = FilterOperator.IsEqualTo;
                    filter.Value =id;
                    filter.IsFilterEditor = true;
                    this.radGridViewProducts.FilterDescriptors.Add(filter);
                }
            }
            
        }

        private void commandBarButtonEdit_Click(object sender, EventArgs e)
        {
            if (radGridViewProducts.SelectedRows.Count > 0)
            {
                var selected = radGridViewProducts.SelectedRows[0].DataBoundItem as Model.Product;

                ProductsFormEdit child = new ProductsFormEdit(selected,repository.categories.Get().ToList());
                child.Text = "Изменение записи";

                child.ThemeName = this.ThemeName;

                if (child.ShowDialog() == DialogResult.OK)
                {
                    repository.products.Update(selected);
                };
            }
        }

        private void commandBarButtonAdd_Click(object sender, EventArgs e)
        {
            var add = new Model.Product();

            ProductsFormEdit child = new ProductsFormEdit(add,repository.categories.Get().ToList());
            child.Text = "Добавление записи";

            child.ThemeName = this.ThemeName;

            if (child.ShowDialog() == DialogResult.OK)
            {
                repository.products.Create(add);
            };
        }

        private void commandBarButtonDelete_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this, "Вы уверены в том, что желаете удалить данную запись?", "Внимание!", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {

                var selected = radGridViewProducts.SelectedRows[0].DataBoundItem as Model.Product;

                repository.products.Delete(selected);

                //radGridViewProducts.Rows.Remove(radGridViewProducts.CurrentRow);
            }
        }

        private void commandBarButtonPrint_Click(object sender, EventArgs e)
        {

            RadForm child = new RadForm();
            child.ThemeName = ThemeName;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Size = new Size(980, 900);
            child.ShowInTaskbar = false;
            child.Text = "Печатная форма";

            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Name = "reportViewerProducts";

            //Report
            ProductsReport report = new ProductsReport();

            report.ReportParameters["Category"].Value = radDropDownListCategories.Text;


            report.tableList.DataSource = radGridViewProducts.MasterTemplate.DataView.Select(o=>o.DataBoundItem as Model.Product) ;

            Random random = new Random();
            var dayproduct = repository.products.Get().ToList().ElementAt(random.Next(repository.products.Get().Count()));
            report.textBoxDayProduct.Value = dayproduct.name + " всего за "+ dayproduct.price.ToString("c");

            var typeReportSource = new Telerik.Reporting.InstanceReportSource();
            typeReportSource.ReportDocument = report;
            reportViewer.ReportSource = typeReportSource;
            reportViewer.ViewMode = ViewMode.PrintPreview;
            reportViewer.RefreshReport();
            child.Controls.Add(reportViewer);

            child.ShowDialog();

        }

        private void radMenuItemXMLImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML File (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filename = openFileDialog.FileName;

            XDocument doc = XDocument.Load(filename);
            foreach (XElement menu in doc.Root.Elements())
            {
                if (menu.Name.LocalName == "Каталог")
                {
                    foreach (XElement xproduct in menu.Elements())
                    {
                        var keyproduct = xproduct.Element("Наименование").Value;
                        var product = ((IEnumerable<Model.Product>)radGridViewProducts.DataSource).FirstOrDefault(p => p.name == keyproduct);

                        if (product == null)
                            product = new Model.Product();
                        
                        product.name= xproduct.Element("Наименование").Value;
                        product.date = Convert.ToDateTime(xproduct.Element("ДатаПроизводства").Value);
                        product.price = Convert.ToDecimal(xproduct.Element("Цена").Value.ToString().Replace(".",","));
                        product.unitsinstock = Convert.ToInt32(xproduct.Element("ВНаличии").Value);


                        var xcategory = xproduct.Element("Категория");
                        var keycategory=xcategory.Element("Наименование").Value;

                        var category =repository.categories.Get().FirstOrDefault(p => p.name == keycategory);
                        if (category == null)
                        {
                           
                            category = new Model.Category();

                            category.id = repository.categories.Get().Count() + 1;
                            category.code = Convert.ToInt32(xcategory.Element("Код").Value);  
                            category.name = xcategory.Element("Наименование").Value;
                            repository.categories.Create(category);
                        }

                        product.categoryid = category.id;

                        if (product.id == 0)
                        {
                            product.id = repository.products.Get().Count() + 1;
                            repository.products.Create(product);
                        };
                    }
                };
            }
            radGridViewProducts.DataSource = null;
            SetDataSource();
        }

        private void radMenuItemXMLExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML File (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if (saveFileDialog.FileName.Equals(String.Empty))
            {
                RadMessageBox.SetThemeName(this.radGridViewProducts.ThemeName);
                RadMessageBox.Show("Пожалуйста, укажите имя файла.");
                return;
            }

            string fileName = saveFileDialog.FileName;

            //XNamespace pfr = "http://пф.рф/ВС/СЗВ-М/2017-01-01";
            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
           
            XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-8", null), 
                new XElement("ЭДПФР",
                                                 new XAttribute(XNamespace.Xmlns + "xsi", xsi.NamespaceName)
                                                ));

            XElement pricelist = new XElement("Каталог");
            
            foreach (Model.Product product in (IEnumerable<Model.Product>)radGridViewProducts.DataSource)
            {
                XElement element = new XElement("Продукт",
                    new XAttribute("НомерПП", pricelist.Elements("Продукт").Count()+1),
                    new XElement("Наименование", product.name),
                    new XElement("Категория",
                             new XElement("Код", product.category.code),
                             new XElement("Наименование", product.category.name)),
                    new XElement("Цена", product.price),
                    new XElement("ДатаПроизводства", product.date.ToString("yyyy-MM-dd")),
                    new XElement("ВНаличии", product.unitsinstock)

                        );
                pricelist.Add(element);
                    
            }

            xDoc.Element("ЭДПФР").Add(pricelist);

            xDoc.Element("ЭДПФР").Add(new XElement("СлужебнаяИнформация",
                                                     new XElement("ДатаВремя", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")),
                                                     new XElement("ПрограммаПодготовки", Application.ProductName.ToUpper() + " " + Application.ProductVersion)
                                                     )
                                           );
            try
            {
                using (var writer = new XmlTextWriter(fileName, new UTF8Encoding(false)) { Formatting = Formatting.Indented })
                {
                    xDoc.Save(writer);
                }
                RadMessageBox.SetThemeName(this.radGridViewProducts.ThemeName);
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
                RadMessageBox.SetThemeName(this.radGridViewProducts.ThemeName); RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);

            }
            
        }
    }
}
