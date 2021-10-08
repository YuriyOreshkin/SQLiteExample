using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SQLiteExample.UI.Product
{
    public partial class ProductsFormEdit : Telerik.WinControls.UI.RadForm
    {
        private Model.Product product;
        private List<Model.Category> categories;
        public ProductsFormEdit(Model.Product _product,List<Model.Category> _categories)
        {
            InitializeComponent();

            product = _product;
            categories = _categories;
        }

        private void ProductsFormEdit_Load(object sender, EventArgs e)
        {

            
            radTextBoxName.Text = product.name;
            radDateTimePickerDate.Value = product.date;
            radCheckBoxInStock.Checked = product.instock;
            radSpinEditorPrice.Value = product.price;
            radSpinEditorUnits.Value = product.unitsinstock;

            radDropDownListCategory.DataSource = categories;
            radDropDownListCategory.ValueMember = "id";
            radDropDownListCategory.DisplayMember = "name";

            radDropDownListCategory.SelectedValue = product.categoryid; 

        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                product.name = radTextBoxName.Text;
                product.date = radDateTimePickerDate.Value; 
                product.price = radSpinEditorPrice.Value;
                product.instock = radCheckBoxInStock.Checked;
                product.unitsinstock = (int)radSpinEditorUnits.Value;
                product.categoryid = (long)radDropDownListCategory.SelectedValue;
            }
            else
            {

                this.DialogResult = DialogResult.None;

            }
        }

        private bool IsValidate()
        {
            if (radSpinEditorPrice.Value < 0)
            {
                errorProvider.SetError(radSpinEditorPrice, "Поле \"Цена\" не должено иметь отрицательное значение!");
                return false;
            }

            if (String.IsNullOrEmpty(radTextBoxName.Text))
            {
                errorProvider.SetError(radTextBoxName, "Поле \"Наименование\" обязательно для заполнения!");
                return false;
            }

            if (radDropDownListCategory.SelectedIndex < 0)
            {
                errorProvider.SetError(radDropDownListCategory, "Выберите категорию!");
                return false;
            }

            

            return true;
        }

        private void radSpinEditorUnits_ValueChanged(object sender, EventArgs e)
        {
            if (this.radSpinEditorUnits.Value > 0)
            {
                radCheckBoxInStock.Checked = true;
            }
            else
            {
                radCheckBoxInStock.Checked = false;
            }
        }
    }
}
