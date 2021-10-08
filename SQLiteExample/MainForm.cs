using SQLiteExample.UI.Model;
using SQLiteExample.UI.Category;
using SQLiteExample.UI.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI.Localization;
using System.IO;

namespace SQLiteExample.UI
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        MdiClient client;
        IRepository repository;
        private string dockLayoutPath = Application.StartupPath + "\\dock.xml";

        public MainForm()
        {
            InitializeComponent();
            //Init repository

            repository = new EFRepository();


            //client = Controls.OfType<MdiClient>().First();
            //This will check whenever client gets focused and there aren't any
            //child forms opened, Send the client to back so that the other controls can be shown back.
           /* client.GotFocus += (s, e) =>
            {
                if (!MdiChildren.Any(x => x.Visible))
                {
                    client.SendToBack();
                    rd.SendToBack();
                    rd.Dock = DockStyle.None;
                    rd.Visible = false;
                }
            };*/

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RadGridLocalizationProvider.CurrentProvider = new RussianRadGridLocalizationProvider();
            RadMessageLocalizationProvider.CurrentProvider = new RussianRadMessageBoxLocalizationProvider();

            this.Controls.Add(rd);
            rd.DocumentManager.DocumentInsertOrder = DockWindowInsertOrder.ToBack;
            /*rd.DockWindowClosed += (s, v) =>
            {
                if (!rd.MdiChildren.Any())
                {
                    rd.SendToBack();
                    rd.Dock = DockStyle.None;
                    rd.Visible = false;
                }
            };*/

            if (File.Exists(dockLayoutPath))
            {
                this.rd.LoadFromXml(dockLayoutPath);
                LoadContent();

            }

            
            
           

           
           


        }

        private void ShowForm(Form childForm)
        {
            if (!rd.Visible)
            {
                rd.Visible = true;
                rd.BringToFront();
                rd.Dock = DockStyle.Fill;
            }

            this.Cursor = Cursors.WaitCursor;
            
            if (rd.MdiChildren.Any(x => x.GetType() == childForm.GetType()))
            {
                rd.MdiChildren.First(x => x.GetType() == childForm.GetType()).Select();

            }
            else
            {
                childForm.MdiParent =this;
                childForm.Show();
            }

            childForm.Focus();
            this.Cursor = Cursors.Default;
        }

        private void MenuItemDirectoriesCategories_Click(object sender, EventArgs e)
        {
            CategoriesFormList child = new CategoriesFormList(repository);

            child.radGridViewCategories.DoubleClick += new System.EventHandler(child.commandBarButtonEdit_Click);

            child.ThemeName = this.ThemeName;
            
            ShowForm(child);
            

        }

        private void LoadContent()
        {
            if (this.rd.DockWindows.Count > 0)
            {
                rd.Visible = true;
                rd.BringToFront();
                rd.Dock = DockStyle.Fill;

            }

            for (int i = 0; i < this.rd.DockWindows.Count; i++)
            {
                HostWindow hw = this.rd.DockWindows[i] as HostWindow;
                if (hw != null)
                {
                   if (hw.Name.StartsWith("CategoriesFormList"))
                    {
                        var form = new CategoriesFormList(repository);
                        hw.LoadContent(form);
                       
                    }
                   if (hw.Name.StartsWith("ProductsFormList"))
                    {

                        var form = new ProductsFormList(repository);
                        hw.LoadContent(form);
                        hw.Text = form.Text;
                    }
                }
            }
        }

        private void MenuItemDirectoriesProducts_Click(object sender, EventArgs e)
        {
            ProductsFormList child = new ProductsFormList(repository);

            child.ThemeName = this.ThemeName;

            ShowForm(child);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rd.SaveToXml(dockLayoutPath);
        }

        private void radMenuItem_Click(object sender, EventArgs e)
        {
            Test child = new Test();

            child.ThemeName = this.ThemeName;

            child.ShowDialog();
        }
    }
}
