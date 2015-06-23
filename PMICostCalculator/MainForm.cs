using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 切换界面语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageSwitch(object sender, EventArgs e)
        {
            ToolStripMenuItem CurrentItem = sender as ToolStripMenuItem;

            foreach (var item in languageToolStripMenuItem.DropDownItems)
            {
                ToolStripMenuItem TmpItem = item as ToolStripMenuItem;
                if (TmpItem.Name==CurrentItem.Name)
                {
                    TmpItem.Checked = true;
                }
                else
                {
                   TmpItem.Checked = false;
                }
            }
        }



    }
}
