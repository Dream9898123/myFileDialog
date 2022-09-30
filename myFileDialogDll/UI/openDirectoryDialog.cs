using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace myFileDialogDll.UI
{
    public partial class openDirectoryDialog : Form
    {
        public openDirectoryDialog()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.IsExpanded)
            {
                e.Node.ExpandAll();
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
