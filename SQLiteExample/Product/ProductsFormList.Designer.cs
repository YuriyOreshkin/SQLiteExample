using System;

namespace SQLiteExample.UI.Product
{
    partial class ProductsFormList
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsFormList));
            this.radLabelCategory = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownListCategories = new Telerik.WinControls.UI.RadDropDownList();
            this.radButtonSelectCategory = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGridViewProducts = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElementMain = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButtonAdd = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButtonEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButtonDelete = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButtonPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarDropDownButtonXML = new Telerik.WinControls.UI.CommandBarDropDownButton();
            this.radMenuItemExport = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemImport = new Telerik.WinControls.UI.RadMenuItem();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButtonClose = new Telerik.WinControls.UI.CommandBarButton();
            this.radCommandProducts = new Telerik.WinControls.UI.RadCommandBar();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelectCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabelCategory
            // 
            this.radLabelCategory.Location = new System.Drawing.Point(4, 14);
            this.radLabelCategory.Name = "radLabelCategory";
            this.radLabelCategory.Size = new System.Drawing.Size(61, 18);
            this.radLabelCategory.TabIndex = 0;
            this.radLabelCategory.Text = "Категория:";
            // 
            // radDropDownListCategories
            // 
            this.radDropDownListCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radDropDownListCategories.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownListCategories.Location = new System.Drawing.Point(71, 14);
            this.radDropDownListCategories.Name = "radDropDownListCategories";
            this.radDropDownListCategories.Size = new System.Drawing.Size(530, 20);
            this.radDropDownListCategories.TabIndex = 1;
            this.radDropDownListCategories.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListCategories_SelectedIndexChanged);
            // 
            // radButtonSelectCategory
            // 
            this.radButtonSelectCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSelectCategory.Location = new System.Drawing.Point(605, 14);
            this.radButtonSelectCategory.Name = "radButtonSelectCategory";
            this.radButtonSelectCategory.Size = new System.Drawing.Size(27, 20);
            this.radButtonSelectCategory.TabIndex = 2;
            this.radButtonSelectCategory.Text = "...";
            this.radButtonSelectCategory.Click += new System.EventHandler(this.radButtonSelectCategory_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButtonSelectCategory);
            this.radPanel1.Controls.Add(this.radLabelCategory);
            this.radPanel1.Controls.Add(this.radDropDownListCategories);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(640, 43);
            this.radPanel1.TabIndex = 3;
            // 
            // radGridViewProducts
            // 
            this.radGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewProducts.Location = new System.Drawing.Point(0, 100);
            // 
            // 
            // 
            this.radGridViewProducts.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewProducts.MasterTemplate.AllowDeleteRow = false;
            this.radGridViewProducts.MasterTemplate.AllowEditRow = false;
            this.radGridViewProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewProducts.MasterTemplate.EnableFiltering = true;
            this.radGridViewProducts.MasterTemplate.EnableGrouping = false;
            this.radGridViewProducts.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewProducts.Name = "radGridViewProducts";
            this.radGridViewProducts.Size = new System.Drawing.Size(640, 172);
            this.radGridViewProducts.TabIndex = 5;
            this.radGridViewProducts.DoubleClick += new System.EventHandler(this.commandBarButtonEdit_Click);
            // 
            // commandBarRowElementMain
            // 
            this.commandBarRowElementMain.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElementMain.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElementMain.Name = "commandBarRowElementMain";
            this.commandBarRowElementMain.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElementMain.Text = "";
            this.commandBarRowElementMain.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElementMain.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.commandBarStripElement1.ClipDrawing = false;
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButtonAdd,
            this.commandBarButtonEdit,
            this.commandBarButtonDelete,
            this.commandBarSeparator1,
            this.commandBarButtonPrint,
            this.commandBarSeparator2,
            this.commandBarDropDownButtonXML,
            this.commandBarSeparator3,
            this.commandBarButtonClose});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // 
            // 
            this.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.commandBarStripElement1.StretchHorizontally = false;
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarButtonAdd
            // 
            this.commandBarButtonAdd.AccessibleDescription = "commandBarButtonAdd";
            this.commandBarButtonAdd.AccessibleName = "commandBarButtonAdd";
            this.commandBarButtonAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonAdd.DisplayName = "Добавить";
            this.commandBarButtonAdd.DrawText = true;
            this.commandBarButtonAdd.FlipText = false;
            this.commandBarButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButtonAdd.Image")));
            this.commandBarButtonAdd.Name = "commandBarButtonAdd";
            this.commandBarButtonAdd.Text = "Добавить";
            this.commandBarButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonAdd.ToolTipText = "Добавить";
            this.commandBarButtonAdd.UseCompatibleTextRendering = false;
            this.commandBarButtonAdd.Click += new System.EventHandler(this.commandBarButtonAdd_Click);
            // 
            // commandBarButtonEdit
            // 
            this.commandBarButtonEdit.AccessibleDescription = "commandBarButtonEdit";
            this.commandBarButtonEdit.AccessibleName = "commandBarButtonEdit";
            this.commandBarButtonEdit.ClipText = false;
            this.commandBarButtonEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonEdit.DisplayName = "Изменить";
            this.commandBarButtonEdit.DrawText = true;
            this.commandBarButtonEdit.Image = global::SQLiteExample.UI.Properties.Resources.edit_24px;
            this.commandBarButtonEdit.Name = "commandBarButtonEdit";
            this.commandBarButtonEdit.Text = "Изменить";
            this.commandBarButtonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonEdit.ToolTipText = "Изменить";
            this.commandBarButtonEdit.UseCompatibleTextRendering = false;
            this.commandBarButtonEdit.Click += new System.EventHandler(this.commandBarButtonEdit_Click);
            // 
            // commandBarButtonDelete
            // 
            this.commandBarButtonDelete.AccessibleDescription = "commandBarButtonDelete";
            this.commandBarButtonDelete.AccessibleName = "commandBarButtonDelete";
            this.commandBarButtonDelete.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonDelete.DisplayName = "commandBarButtonDelete";
            this.commandBarButtonDelete.DrawText = true;
            this.commandBarButtonDelete.Image = global::SQLiteExample.UI.Properties.Resources.delete_24px;
            this.commandBarButtonDelete.Name = "commandBarButtonDelete";
            this.commandBarButtonDelete.Text = "Удалить";
            this.commandBarButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonDelete.ToolTipText = "Удалить";
            this.commandBarButtonDelete.UseCompatibleTextRendering = false;
            this.commandBarButtonDelete.Click += new System.EventHandler(this.commandBarButtonDelete_Click);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.UseCompatibleTextRendering = false;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarButtonPrint
            // 
            this.commandBarButtonPrint.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonPrint.DisplayName = "commandBarButton1";
            this.commandBarButtonPrint.DrawText = true;
            this.commandBarButtonPrint.Image = global::SQLiteExample.UI.Properties.Resources.print_24px;
            this.commandBarButtonPrint.Name = "commandBarButtonPrint";
            this.commandBarButtonPrint.Text = "Печать";
            this.commandBarButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonPrint.UseCompatibleTextRendering = false;
            this.commandBarButtonPrint.Click += new System.EventHandler(this.commandBarButtonPrint_Click);
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.UseCompatibleTextRendering = false;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarDropDownButtonXML
            // 
            this.commandBarDropDownButtonXML.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarDropDownButtonXML.DisplayName = "XML";
            this.commandBarDropDownButtonXML.DrawText = true;
            this.commandBarDropDownButtonXML.Image = global::SQLiteExample.UI.Properties.Resources.code_24px;
            this.commandBarDropDownButtonXML.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemExport,
            this.radMenuItemImport});
            this.commandBarDropDownButtonXML.Name = "commandBarDropDownButtonXML";
            this.commandBarDropDownButtonXML.Text = "XML";
            this.commandBarDropDownButtonXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarDropDownButtonXML.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarDropDownButtonXML.UseCompatibleTextRendering = false;
            // 
            // radMenuItemExport
            // 
            this.radMenuItemExport.Name = "radMenuItemExport";
            this.radMenuItemExport.Text = "Экспорт";
            this.radMenuItemExport.UseCompatibleTextRendering = false;
            this.radMenuItemExport.Click += new System.EventHandler(this.radMenuItemXMLExport_Click);
            // 
            // radMenuItemImport
            // 
            this.radMenuItemImport.Name = "radMenuItemImport";
            this.radMenuItemImport.Text = "Импорт";
            this.radMenuItemImport.UseCompatibleTextRendering = false;
            this.radMenuItemImport.Click += new System.EventHandler(this.radMenuItemXMLImport_Click);
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.DisplayName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.UseCompatibleTextRendering = false;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarButtonClose
            // 
            this.commandBarButtonClose.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonClose.DisplayName = "commandBarButton1";
            this.commandBarButtonClose.DrawText = true;
            this.commandBarButtonClose.Image = global::SQLiteExample.UI.Properties.Resources.close_24px;
            this.commandBarButtonClose.Name = "commandBarButtonClose";
            this.commandBarButtonClose.Text = "Закрыть";
            this.commandBarButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButtonClose.UseCompatibleTextRendering = false;
            this.commandBarButtonClose.Click += new System.EventHandler(this.commandBarButtonClose_Click);
            // 
            // radCommandProducts
            // 
            this.radCommandProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandProducts.Location = new System.Drawing.Point(0, 43);
            this.radCommandProducts.Name = "radCommandProducts";
            this.radCommandProducts.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElementMain});
            this.radCommandProducts.Size = new System.Drawing.Size(640, 57);
            this.radCommandProducts.TabIndex = 4;
            // 
            // ProductsFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 272);
            this.Controls.Add(this.radGridViewProducts);
            this.Controls.Add(this.radCommandProducts);
            this.Controls.Add(this.radPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsFormList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Каталог продуктов";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.ProductsFormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSelectCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabelCategory;
        private Telerik.WinControls.UI.RadButton radButtonSelectCategory;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView radGridViewProducts;
        internal Telerik.WinControls.UI.RadDropDownList radDropDownListCategories;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElementMain;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonAdd;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonEdit;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonDelete;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonPrint;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButtonXML;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExport;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemImport;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonClose;
        public Telerik.WinControls.UI.RadCommandBar radCommandProducts;
    }
}
