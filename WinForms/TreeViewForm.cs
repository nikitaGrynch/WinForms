using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForms
{
    public partial class TreeViewForm : Form
    {
        TreeView treeView;
        public TreeViewForm()
        {
            InitializeComponent();
            treeView = new TreeView();
            treeView.Bounds = new Rectangle(new Point(10, 50), new Size(400, 500));
            this.Controls.Add(treeView);
            parseDirectory("C:\\1", treeView.Nodes);
        }

        private void parseDirectory(String currentDirectory, TreeNodeCollection node)
        {
            TreeNode currentNode = node.Add(currentDirectory);
            foreach (var file in Directory.GetFiles(currentDirectory))
            {
                currentNode.Nodes.Add(file);
            }

            foreach(var dir in Directory.GetDirectories(currentDirectory)){
                parseDirectory(dir, currentNode.Nodes);
            }
        }
    }
}
