using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MessageBox = System.Windows.Forms.MessageBox;
using TreeView = System.Windows.Forms.TreeView;

namespace myFileDialogDll.UI
{
    public partial class openDirectoryDialog : Form
    {
        private string lastPath;
        private string selectPath;

        public string SelectPath
        {
            get
            {
                if (string.IsNullOrEmpty(selectPath))
                    selectPath = initPath;
                return selectPath;
            }

            set
            {
                selectPath = value;
            }
        }

        public string InitPath
        {
            get
            {
                if (string.IsNullOrEmpty(initPath))
                    initPath = selectPath;
                return initPath;
            }

            set
            {
                initPath = value;
            }
        }

        private string initPath;

        public openDirectoryDialog()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (!e.Node.IsExpanded)
            //{
            //    e.Node.ExpandAll();
            //}
            string virlPath = GetVirPath(e.Node.Tag.ToString());
            this.comboBox1.Text = virlPath;
            if(!this.comboBox1.Items.Contains(virlPath))
            {
                this.comboBox1.Items.Add(this.comboBox1.Text);
            }
            this.SelectPath = this.treeView1.SelectedNode.Tag.ToString();
            Console.WriteLine("选择的路径：" + this.SelectPath);
        }
        private string GetVirPath(string fullPath)
        {
            string virlPath = "";
            virlPath = fullPath.Substring(InitPath.Length);
            virlPath = @"..\" + this.treeView1.Tag.ToString() + virlPath;
            return virlPath;
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }
        private void PaintTreeView(TreeView treeView, string fullPath)
        {
            if (string.IsNullOrEmpty(InitPath))
            {
                throw new Exception("初始目录无效");
            }
            if (!Directory.Exists(InitPath))
            {
                throw new Exception("目录无效");
            }
            if (!SelectPath.Contains(InitPath))
            {
                throw new Exception("目录无效");
            }
            try
            {
                treeView.Nodes.Clear(); //清空TreeView
                TreeNode root = new TreeNode();
                root.Text = Path.GetFileName(InitPath);
                this.treeView1.Tag = root.Text;
                root.Tag = InitPath;
                treeView1.Nodes.Add(root);
                BindChild(root);

                ForceView(this.treeView1.Nodes[0],SelectPath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n出错的位置为：Form1.PaintTreeView()");
            }
        }

        private void BindChild(TreeNode fNode)
        {
            string path = fNode.Tag.ToString();


            //父目录
            DirectoryInfo fDir = new DirectoryInfo(path);
            FileSystemInfo[] finfos = fDir.GetFileSystemInfos();

            foreach (FileSystemInfo f in finfos)
            {
                string type = f.GetType().ToString();
                TreeNode node = new TreeNode();
                node.Text = f.Name;
                node.Tag = f.FullName;

                if ("System.IO.DirectoryInfo" == type) //是文件夹时才递归调用自己
                {
                    fNode.Nodes.Add(node);
                    BindChild(node);
                }
            }
        }

        private void openDirectoryDialog_Load(object sender, EventArgs e)
        {
            this.lastPath = SelectPath;
            PaintTreeView(this.treeView1, SelectPath);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
            if (this.panel1.Visible)
                this.toolStripLabel1.Text = "隐藏路径";
            else
                this.toolStripLabel1.Text = "显示路径";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void ForceView(TreeNode treeNode,string comStr)
        {
            if (!string.IsNullOrEmpty(treeNode.Tag.ToString()))
            {
                if (treeNode.Tag.ToString().Equals(comStr))
                {
                    this.treeView1.SelectedNode = treeNode;
                    this.treeView1.Focus();
                    return;
                }
            }
            foreach (TreeNode node in treeNode.Nodes)
            {
                ForceView(node,comStr);
            }
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (!this.comboBox1.Focused)
            {
                this.lbInfo.Text = "";
                this.toolStrip1.Enabled = true;
                this.btnOK.Enabled = true;
                return;
            }
            string selectValue = this.comboBox1.Text;
            string vailName = @"..\" + this.treeView1.Tag.ToString();
            string fullPath = InitPath + selectValue.Substring(vailName.Length);
            ForceView(this.treeView1.Nodes[0], fullPath);
            if (this.comboBox1.Focused)
            {
                this.lbInfo.Text = "未找到路径";
                this.toolStrip1.Enabled = false;
                this.btnOK.Enabled = false;
            }
            else
            {
                this.lbInfo.Text = "";
                this.toolStrip1.Enabled = true;
                this.btnOK.Enabled = true;
            }
        }

        private void btnHomeDir_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode = this.treeView1.Nodes[0];
            this.treeView1.Focus();
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            using(AddFileName addFileName = new AddFileName())
            {
                addFileName.CreatePath = this.SelectPath;
                if(addFileName.ShowDialog(this) == DialogResult.OK)
                {
                    Directory.CreateDirectory(addFileName.CreatePath);
                    PaintTreeView(this.treeView1, SelectPath);
                }
            }
        }

        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Directory.Delete(this.SelectPath,true);
                this.SelectPath = Path.GetDirectoryName(this.SelectPath);
                PaintTreeView(this.treeView1, SelectPath);
            };
        }

        private void btnReflush_Click(object sender, EventArgs e)
        {
            PaintTreeView(this.treeView1, SelectPath);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void openDirectoryDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                this.SelectPath = this.lastPath;
        }
    }
}
