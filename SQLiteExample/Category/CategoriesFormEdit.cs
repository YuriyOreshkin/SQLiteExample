using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLiteExample.UI.Model;

namespace SQLiteExample.UI.Category
{
    public partial class CategoriesFormEdit : Telerik.WinControls.UI.RadForm
    {
        private Model.Category category;

        public CategoriesFormEdit(Model.Category _category)
        {
            InitializeComponent();
            category = _category;

            //
            //radDataEntry1.DataSource = category;
        }

        private void CategoriesFormEdit_Load(object sender, EventArgs e)
        {
            radSpinEditorCode.Value = category.code;
            radTextBoxName.Text = category.name;
            
           
        }

        private void radButtonSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                category.code = (int)radSpinEditorCode.Value;
                category.name = radTextBoxName.Text;
            }
            else {

                this.DialogResult = DialogResult.None;

            }
        }

       

        private bool IsValidate() {

            if (radSpinEditorCode.Value <= 0)
            {
                errorProvider.SetError(radSpinEditorCode, "Поле \"Код\" должено содержать значение больше 0!");
                return false;
            }

            if (String.IsNullOrEmpty(radTextBoxName.Text))
            {
                errorProvider.SetError(radTextBoxName, "Поле \"Наименование\" обязательно для заполнения!");
                return false;
            }

            return true;
        }

        private void radButtonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
