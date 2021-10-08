namespace SQLiteExample.UI.Category
{
    partial class CategoriesFormEdit
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
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            this.radSpinEditorCode = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabelCode = new Telerik.WinControls.UI.RadLabel();
            this.radLabelName = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxName = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBoxCategory = new Telerik.WinControls.UI.RadGroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCategory)).BeginInit();
            this.radGroupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.radButtonCancel.Image = global::SQLiteExample.UI.Properties.Resources.block_24px;
            this.radButtonCancel.Location = new System.Drawing.Point(304, 137);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(110, 24);
            this.radButtonCancel.TabIndex = 3;
            this.radButtonCancel.Text = "Отмена";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.radButtonSave.Image = global::SQLiteExample.UI.Properties.Resources.save_24px;
            this.radButtonSave.Location = new System.Drawing.Point(182, 137);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(110, 24);
            this.radButtonSave.TabIndex = 2;
            this.radButtonSave.Text = "Сохранить";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // radSpinEditorCode
            // 
            this.radSpinEditorCode.Location = new System.Drawing.Point(123, 21);
            this.radSpinEditorCode.Name = "radSpinEditorCode";
            this.radSpinEditorCode.Size = new System.Drawing.Size(100, 20);
            this.radSpinEditorCode.TabIndex = 4;
            // 
            // radLabelCode
            // 
            this.radLabelCode.Location = new System.Drawing.Point(14, 24);
            this.radLabelCode.Name = "radLabelCode";
            this.radLabelCode.Size = new System.Drawing.Size(26, 18);
            this.radLabelCode.TabIndex = 5;
            this.radLabelCode.Text = "Код";
            // 
            // radLabelName
            // 
            this.radLabelName.Location = new System.Drawing.Point(14, 62);
            this.radLabelName.Name = "radLabelName";
            this.radLabelName.Size = new System.Drawing.Size(84, 18);
            this.radLabelName.TabIndex = 6;
            this.radLabelName.Text = "Наименование";
            // 
            // radTextBoxName
            // 
            this.radTextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTextBoxName.Location = new System.Drawing.Point(123, 60);
            this.radTextBoxName.Name = "radTextBoxName";
            this.radTextBoxName.Size = new System.Drawing.Size(271, 20);
            this.radTextBoxName.TabIndex = 7;
            // 
            // radGroupBoxCategory
            // 
            this.radGroupBoxCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBoxCategory.Controls.Add(this.radTextBoxName);
            this.radGroupBoxCategory.Controls.Add(this.radSpinEditorCode);
            this.radGroupBoxCategory.Controls.Add(this.radLabelCode);
            this.radGroupBoxCategory.Controls.Add(this.radLabelName);
            this.radGroupBoxCategory.HeaderText = "Категория";
            this.radGroupBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.radGroupBoxCategory.Name = "radGroupBoxCategory";
            this.radGroupBoxCategory.Size = new System.Drawing.Size(402, 100);
            this.radGroupBoxCategory.TabIndex = 9;
            this.radGroupBoxCategory.Text = "Категория";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CategoriesFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 173);
            this.Controls.Add(this.radGroupBoxCategory);
            this.Controls.Add(this.radButtonCancel);
            this.Controls.Add(this.radButtonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoriesFormEdit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CategoriesFormEdit";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.CategoriesFormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBoxCategory)).EndInit();
            this.radGroupBoxCategory.ResumeLayout(false);
            this.radGroupBoxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorCode;
        private Telerik.WinControls.UI.RadLabel radLabelCode;
        private Telerik.WinControls.UI.RadLabel radLabelName;
        private Telerik.WinControls.UI.RadTextBox radTextBoxName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBoxCategory;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
