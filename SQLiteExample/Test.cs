using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SQLiteExample.UI
{
    public partial class Test : Telerik.WinControls.UI.RadForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            ////button = (Button)Utils.CloneObject(buttonClone);
            //button.Name = "button";
            //button.Text = "ewdewd";
            //button.Top = 0;
            //button.Left = 0;
            //this.Controls.Add(button);

            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    Button button = new Button();
                    //button = Utils.Clone(buttonClone);
                    button.Name = "button_" + i + "_" + j;
                    button.Text = button.Name;
                    tableLayoutPanel.Controls.Add(button, j, i);
                }
            }

        }
    }
}
