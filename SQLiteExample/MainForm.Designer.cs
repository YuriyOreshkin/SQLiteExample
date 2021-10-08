namespace SQLiteExample.UI
{
    partial class MainForm
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
            this.materialTheme = new Telerik.WinControls.Themes.MaterialTheme();
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.MenuItemDirectories = new Telerik.WinControls.UI.RadMenuItem();
            this.MenuItemDirectoriesCategories = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.MenuItemDirectoriesProducts = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentContainer2 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.rd = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer3 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd)).BeginInit();
            this.rd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MenuItemDirectories,
            this.radMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1106, 20);
            this.MainMenu.TabIndex = 0;
            // 
            // MenuItemDirectories
            // 
            this.MenuItemDirectories.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MenuItemDirectoriesCategories,
            this.radMenuSeparatorItem1,
            this.MenuItemDirectoriesProducts});
            this.MenuItemDirectories.Name = "MenuItemDirectories";
            this.MenuItemDirectories.Text = "Справочники";
            // 
            // MenuItemDirectoriesCategories
            // 
            this.MenuItemDirectoriesCategories.Name = "MenuItemDirectoriesCategories";
            this.MenuItemDirectoriesCategories.Text = "Категории";
            this.MenuItemDirectoriesCategories.Click += new System.EventHandler(this.MenuItemDirectoriesCategories_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuItemDirectoriesProducts
            // 
            this.MenuItemDirectoriesProducts.Name = "MenuItemDirectoriesProducts";
            this.MenuItemDirectoriesProducts.Text = "Продукты";
            this.MenuItemDirectoriesProducts.Click += new System.EventHandler(this.MenuItemDirectoriesProducts_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.commandBarSeparator1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 374);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1106, 26);
            this.radStatusStrip1.TabIndex = 1;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "База данных";
            this.radLabelElement1.TextWrap = true;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // documentContainer1
            // 
            this.documentContainer1.Name = "documentContainer1";
            this.documentContainer1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // documentContainer2
            // 
            this.documentContainer2.Name = "documentContainer2";
            this.documentContainer2.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.documentContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // rd
            // 
            this.rd.AutoDetectMdiChildren = true;
            this.rd.Controls.Add(this.documentContainer3);
            this.rd.IsCleanUpTarget = true;
            this.rd.Location = new System.Drawing.Point(0, 35);
            this.rd.MainDocumentContainer = this.documentContainer3;
            this.rd.Name = "rd";
            // 
            // 
            // 
            this.rd.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.rd.ShowDocumentCloseButton = true;
            this.rd.Size = new System.Drawing.Size(551, 256);
            this.rd.TabIndex = 3;
            this.rd.TabStop = false;
            this.rd.Visible = false;
            // 
            // documentContainer3
            // 
            this.documentContainer3.Name = "documentContainer3";
            // 
            // 
            // 
            this.documentContainer3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer3.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // radMenuItem
            // 
            this.radMenuItem.Name = "radMenuItem";
            this.radMenuItem.Text = "Test";
            this.radMenuItem.Click += new System.EventHandler(this.radMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 400);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ThemeName = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd)).EndInit();
            this.rd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme;
        private Telerik.WinControls.UI.RadMenu MainMenu;
        private Telerik.WinControls.UI.RadMenuItem MenuItemDirectories;
        private Telerik.WinControls.UI.RadMenuItem MenuItemDirectoriesCategories;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem MenuItemDirectoriesProducts;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
      
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
      
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;
        public Telerik.WinControls.UI.Docking.RadDock rd;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem;
    }
}