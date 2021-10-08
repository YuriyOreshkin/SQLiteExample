using System;

namespace SQLiteExample.UI.Category
{
    partial class CategoriesFormList
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
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesFormList));
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.radGridViewCategories = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElementMain = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButtonAdd = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButtonEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButtonDelete = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButtonPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarDropDownButtonExport = new Telerik.WinControls.UI.CommandBarDropDownButton();
            this.radMenuItemExportExcel = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemExportCSV = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemExportPDF = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemExportHTML = new Telerik.WinControls.UI.RadMenuItem();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButtonClose = new Telerik.WinControls.UI.CommandBarButton();
            this.radCommandBarCategories = new Telerik.WinControls.UI.RadCommandBar();
            this.radContextMenuCategories = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItemAdd = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemDelete = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItemPrint = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItemExport = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuItemExportExcel = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuItemExportCSV = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuItemExportPDF = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextMenuItemExportHTML = new Telerik.WinControls.UI.RadMenuItem();
            this.radPrintDocumentCategories = new Telerik.WinControls.UI.RadPrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBarCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridViewCategories
            // 
            this.radGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewCategories.Location = new System.Drawing.Point(0, 57);
            // 
            // 
            // 
            this.radGridViewCategories.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewCategories.MasterTemplate.AllowDeleteRow = false;
            this.radGridViewCategories.MasterTemplate.AllowEditRow = false;
            this.radGridViewCategories.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewCategories.MasterTemplate.EnableFiltering = true;
            this.radGridViewCategories.MasterTemplate.EnableGrouping = false;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "Кол-во записей {0}";
            gridViewSummaryItem1.Name = "code";
            this.radGridViewCategories.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.radGridViewCategories.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewCategories.Name = "radGridViewCategories";
            this.radGridViewCategories.ShowGroupPanel = false;
            this.radGridViewCategories.Size = new System.Drawing.Size(563, 215);
            this.radGridViewCategories.TabIndex = 1;
            this.radGridViewCategories.SelectionChanged += new System.EventHandler(this.radGridViewCategories_SelectionChanged);
            this.radGridViewCategories.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.radGridViewCategories_ContextMenuOpening);
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
            this.commandBarDropDownButtonExport,
            this.commandBarSeparator2,
            this.commandBarButtonClose});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // 
            // 
            this.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.Padding = new System.Windows.Forms.Padding(0);
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarButtonPrint
            // 
            this.commandBarButtonPrint.DisplayName = "commandBarButtonPrint";
            this.commandBarButtonPrint.DrawText = true;
            this.commandBarButtonPrint.Image = global::SQLiteExample.UI.Properties.Resources.print_24px;
            this.commandBarButtonPrint.Name = "commandBarButtonPrint";
            this.commandBarButtonPrint.Text = "Печать";
            this.commandBarButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButtonPrint.ToolTipText = "Печать";
            this.commandBarButtonPrint.Click += new System.EventHandler(this.commandBarButtonPrint_Click);
            // 
            // commandBarDropDownButtonExport
            // 
            this.commandBarDropDownButtonExport.DisplayName = "commandBarDropDownButton1";
            this.commandBarDropDownButtonExport.DrawText = true;
            this.commandBarDropDownButtonExport.Image = global::SQLiteExample.UI.Properties.Resources.save_alt_24px;
            this.commandBarDropDownButtonExport.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemExportExcel,
            this.radMenuItemExportCSV,
            this.radMenuItemExportPDF,
            this.radMenuItemExportHTML});
            this.commandBarDropDownButtonExport.Name = "commandBarDropDownButtonExport";
            this.commandBarDropDownButtonExport.Text = "Экспорт";
            this.commandBarDropDownButtonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarDropDownButtonExport.ToolTipText = "Экспорт";
            // 
            // radMenuItemExportExcel
            // 
            this.radMenuItemExportExcel.Name = "radMenuItemExportExcel";
            this.radMenuItemExportExcel.Tag = "0";
            this.radMenuItemExportExcel.Text = "Excel";
            this.radMenuItemExportExcel.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radMenuItemExportCSV
            // 
            this.radMenuItemExportCSV.Name = "radMenuItemExportCSV";
            this.radMenuItemExportCSV.Tag = "1";
            this.radMenuItemExportCSV.Text = "CSV";
            this.radMenuItemExportCSV.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radMenuItemExportPDF
            // 
            this.radMenuItemExportPDF.Name = "radMenuItemExportPDF";
            this.radMenuItemExportPDF.Tag = "2";
            this.radMenuItemExportPDF.Text = "PDF";
            this.radMenuItemExportPDF.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radMenuItemExportHTML
            // 
            this.radMenuItemExportHTML.Name = "radMenuItemExportHTML";
            this.radMenuItemExportHTML.Tag = "3";
            this.radMenuItemExportHTML.Text = "HTML";
            this.radMenuItemExportHTML.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.Padding = new System.Windows.Forms.Padding(0);
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
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
            // radCommandBarCategories
            // 
            this.radCommandBarCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBarCategories.Location = new System.Drawing.Point(0, 0);
            this.radCommandBarCategories.Name = "radCommandBarCategories";
            this.radCommandBarCategories.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElementMain});
            this.radCommandBarCategories.Size = new System.Drawing.Size(563, 57);
            this.radCommandBarCategories.TabIndex = 0;
            // 
            // radContextMenuCategories
            // 
            this.radContextMenuCategories.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemAdd,
            this.radMenuItemEdit,
            this.radMenuItemDelete,
            this.radMenuSeparatorItem1,
            this.radMenuItemPrint,
            this.radMenuSeparatorItem2,
            this.radMenuItemExport});
            // 
            // radMenuItemAdd
            // 
            this.radMenuItemAdd.Name = "radMenuItemAdd";
            this.radMenuItemAdd.Text = "Добавить";
            this.radMenuItemAdd.Click += new System.EventHandler(this.commandBarButtonAdd_Click);
            // 
            // radMenuItemEdit
            // 
            this.radMenuItemEdit.Name = "radMenuItemEdit";
            this.radMenuItemEdit.Text = "Изменить";
            this.radMenuItemEdit.Click += new System.EventHandler(this.commandBarButtonEdit_Click);
            // 
            // radMenuItemDelete
            // 
            this.radMenuItemDelete.Name = "radMenuItemDelete";
            this.radMenuItemDelete.Text = "Удалить";
            this.radMenuItemDelete.Click += new System.EventHandler(this.commandBarButtonDelete_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItemPrint
            // 
            this.radMenuItemPrint.Name = "radMenuItemPrint";
            this.radMenuItemPrint.Text = "Печать";
            this.radMenuItemPrint.Click += new System.EventHandler(this.commandBarButtonPrint_Click);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItemExport
            // 
            this.radMenuItemExport.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radContextMenuItemExportExcel,
            this.radContextMenuItemExportCSV,
            this.radContextMenuItemExportPDF,
            this.radContextMenuItemExportHTML});
            this.radMenuItemExport.Name = "radMenuItemExport";
            this.radMenuItemExport.Text = "Экспорт";
            // 
            // radContextMenuItemExportExcel
            // 
            this.radContextMenuItemExportExcel.Name = "radContextMenuItemExportExcel";
            this.radContextMenuItemExportExcel.Tag = "0";
            this.radContextMenuItemExportExcel.Text = "Excel";
            this.radContextMenuItemExportExcel.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radContextMenuItemExportCSV
            // 
            this.radContextMenuItemExportCSV.Name = "radContextMenuItemExportCSV";
            this.radContextMenuItemExportCSV.Tag = "1";
            this.radContextMenuItemExportCSV.Text = "CSV";
            this.radContextMenuItemExportCSV.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radContextMenuItemExportPDF
            // 
            this.radContextMenuItemExportPDF.Name = "radContextMenuItemExportPDF";
            this.radContextMenuItemExportPDF.Tag = "2";
            this.radContextMenuItemExportPDF.Text = "PDF";
            this.radContextMenuItemExportPDF.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radContextMenuItemExportHTML
            // 
            this.radContextMenuItemExportHTML.Name = "radContextMenuItemExportHTML";
            this.radContextMenuItemExportHTML.Tag = "3";
            this.radContextMenuItemExportHTML.Text = "HTML";
            this.radContextMenuItemExportHTML.Click += new System.EventHandler(this.radMenuItemExportItem_Click);
            // 
            // radPrintDocumentCategories
            // 
            this.radPrintDocumentCategories.AssociatedObject = this.radGridViewCategories;
            this.radPrintDocumentCategories.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPrintDocumentCategories.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPrintDocumentCategories.Watermark = radPrintWatermark1;
            // 
            // CategoriesFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 272);
            this.Controls.Add(this.radGridViewCategories);
            this.Controls.Add(this.radCommandBarCategories);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriesFormList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категории";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CategoriesFormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBarCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        public Telerik.WinControls.UI.RadGridView radGridViewCategories;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElementMain;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonAdd;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonEdit;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonDelete;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonClose;
        public Telerik.WinControls.UI.RadCommandBar radCommandBarCategories;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButtonExport;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExportExcel;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExportCSV;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExportPDF;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExportHTML;
        private Telerik.WinControls.UI.RadContextMenu radContextMenuCategories;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemAdd;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemEdit;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemDelete;
        private Telerik.WinControls.UI.CommandBarButton commandBarButtonPrint;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocumentCategories;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemPrint;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemExport;
        private Telerik.WinControls.UI.RadMenuItem radContextMenuItemExportExcel;
        private Telerik.WinControls.UI.RadMenuItem radContextMenuItemExportCSV;
        private Telerik.WinControls.UI.RadMenuItem radContextMenuItemExportPDF;
        private Telerik.WinControls.UI.RadMenuItem radContextMenuItemExportHTML;
    }
}
