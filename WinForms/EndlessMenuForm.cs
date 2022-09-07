using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class EndlessMenuForm : Form
    {
        private int counter;
        private MenuStrip menuStrip;
        private ToolStripMenuItem prevMenuItem;
        public EndlessMenuForm()
        {
            InitializeComponent();
            counter = 1;
            menuStrip = new MenuStrip();
            menuStrip.Dock = DockStyle.Top;
            prevMenuItem = new ToolStripMenuItem();
            prevMenuItem.Text = counter.ToString();
            menuStrip.Items.Add(prevMenuItem);
            counter++;
            menuStrip.MouseHover += CreateItem;
            this.Controls.Add(menuStrip);
            
        }

        private void CreateItem(object sender, EventArgs e)
        {
            var menuItem = new ToolStripMenuItem();
            menuItem.Text = counter.ToString();
            prevMenuItem.DropDownItems.Add(menuItem);
            menuItem.MouseHover += CreateItem;
            counter++;
            prevMenuItem = menuItem;
        }
    }
}
