namespace SQLiteExample.UI.Product
{
    partial class ProductsFormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radSpinEditorUnits = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelUnits = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListCategory = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabelCategory = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBoxInStock = new Telerik.WinControls.UI.RadCheckBox();
            this.radSpinEditorPrice = new Telerik.WinControls.UI.RadSpinEditor();
            this.radDateTimePickerDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabelPrice = new Telerik.WinControls.UI.RadLabel();
            this.radLabelDate = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelName = new Telerik.WinControls.UI.RadLabel();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radSpinEditorUnits);
            this.radGroupBox1.Controls.Add(this.radLabelUnits);
            this.radGroupBox1.Controls.Add(this.radDropDownListCategory);
            this.radGroupBox1.Controls.Add(this.radLabelCategory);
            this.radGroupBox1.Controls.Add(this.radCheckBoxInStock);
            this.radGroupBox1.Controls.Add(this.radSpinEditorPrice);
            this.radGroupBox1.Controls.Add(this.radDateTimePickerDate);
            this.radGroupBox1.Controls.Add(this.radLabelPrice);
            this.radGroupBox1.Controls.Add(this.radLabelDate);
            this.radGroupBox1.Controls.Add(this.radTextBoxName);
            this.radGroupBox1.Controls.Add(this.radLabelName);
            this.radGroupBox1.HeaderText = "Продукт";
            this.radGroupBox1.Location = new System.Drawing.Point(11, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(433, 228);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = "Продукт";
            // 
            // radSpinEditorUnits
            // 
            this.radSpinEditorUnits.Location = new System.Drawing.Point(95, 161);
            this.radSpinEditorUnits.Name = "radSpinEditorUnits";
            this.radSpinEditorUnits.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditorUnits.TabIndex = 17;
            this.radSpinEditorUnits.ValueChanged += new System.EventHandler(this.radSpinEditorUnits_ValueChanged);
            // 
            // radLabelUnits
            // 
            this.radLabelUnits.Location = new System.Drawing.Point(5, 162);
            this.radLabelUnits.Name = "radLabelUnits";
            this.radLabelUnits.Size = new System.Drawing.Size(67, 18);
            this.radLabelUnits.TabIndex = 16;
            this.radLabelUnits.Text = "Количество";
            // 
            // radDropDownListCategory
            // 
            this.radDropDownListCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListCategory.Location = new System.Drawing.Point(95, 63);
            this.radDropDownListCategory.Name = "radDropDownListCategory";
            this.radDropDownListCategory.Size = new System.Drawing.Size(329, 20);
            this.radDropDownListCategory.TabIndex = 15;
            // 
            // radLabelCategory
            // 
            this.radLabelCategory.Location = new System.Drawing.Point(5, 65);
            this.radLabelCategory.Name = "radLabelCategory";
            this.radLabelCategory.Size = new System.Drawing.Size(59, 18);
            this.radLabelCategory.TabIndex = 14;
            this.radLabelCategory.Text = "Категория";
            // 
            // radCheckBoxInStock
            // 
            this.radCheckBoxInStock.Enabled = false;
            this.radCheckBoxInStock.Location = new System.Drawing.Point(95, 193);
            this.radCheckBoxInStock.Name = "radCheckBoxInStock";
            this.radCheckBoxInStock.Size = new System.Drawing.Size(74, 18);
            this.radCheckBoxInStock.TabIndex = 13;
            this.radCheckBoxInStock.Text = "В наличии";
            // 
            // radSpinEditorPrice
            // 
            this.radSpinEditorPrice.DecimalPlaces = 2;
            this.radSpinEditorPrice.Location = new System.Drawing.Point(95, 129);
            this.radSpinEditorPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.radSpinEditorPrice.Name = "radSpinEditorPrice";
            this.radSpinEditorPrice.ShowUpDownButtons = false;
            this.radSpinEditorPrice.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditorPrice.TabIndex = 11;
            // 
            // radDateTimePickerDate
            // 
            this.radDateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimePickerDate.Location = new System.Drawing.Point(95, 95);
            this.radDateTimePickerDate.Name = "radDateTimePickerDate";
            this.radDateTimePickerDate.Size = new System.Drawing.Size(164, 20);
            this.radDateTimePickerDate.TabIndex = 10;
            this.radDateTimePickerDate.TabStop = false;
            this.radDateTimePickerDate.Value = new System.DateTime(((long)(0)));
            // 
            // radLabelPrice
            // 
            this.radLabelPrice.Location = new System.Drawing.Point(5, 129);
            this.radLabelPrice.Name = "radLabelPrice";
            this.radLabelPrice.Size = new System.Drawing.Size(33, 18);
            this.radLabelPrice.TabIndex = 9;
            this.radLabelPrice.Text = "Цена";
            // 
            // radLabelDate
            // 
            this.radLabelDate.Location = new System.Drawing.Point(5, 95);
            this.radLabelDate.Name = "radLabelDate";
            this.radLabelDate.Size = new System.Drawing.Size(30, 18);
            this.radLabelDate.TabIndex = 8;
            this.radLabelDate.Text = "Дата";
            // 
            // radTextBoxName
            // 
            this.radTextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxName.Location = new System.Drawing.Point(95, 30);
            this.radTextBoxName.Name = "radTextBoxName";
            this.radTextBoxName.Size = new System.Drawing.Size(329, 20);
            this.radTextBoxName.TabIndex = 7;
            // 
            // radLabelName
            // 
            this.radLabelName.Location = new System.Drawing.Point(5, 30);
            this.radLabelName.Name = "radLabelName";
            this.radLabelName.Size = new System.Drawing.Size(84, 18);
            this.radLabelName.TabIndex = 6;
            this.radLabelName.Text = "Наименование";
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.radButtonCancel.Image = global::SQLiteExample.UI.Properties.Resources.block_24px;
            this.radButtonCancel.Location = new System.Drawing.Point(334, 258);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(110, 24);
            this.radButtonCancel.TabIndex = 12;
            this.radButtonCancel.Text = "Отмена";
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.radButtonSave.Image = global::SQLiteExample.UI.Properties.Resources.save_24px;
            this.radButtonSave.Location = new System.Drawing.Point(212, 258);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(110, 24);
            this.radButtonSave.TabIndex = 11;
            this.radButtonSave.Text = "Сохранить";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductsFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 294);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonSave);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsFormEdit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsFormEdit";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.ProductsFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerDate;
        private Telerik.WinControls.UI.RadLabel radLabelPrice;
        private Telerik.WinControls.UI.RadLabel radLabelDate;
        private Telerik.WinControls.UI.RadTextBox radTextBoxName;
        private Telerik.WinControls.UI.RadLabel radLabelName;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorPrice;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxInStock;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListCategory;
        private Telerik.WinControls.UI.RadLabel radLabelCategory;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorUnits;
        private Telerik.WinControls.UI.RadLabel radLabelUnits;
    }
}
