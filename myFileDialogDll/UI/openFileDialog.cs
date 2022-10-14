using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;

namespace myFileDialogDll.UI
{
    public partial class openFileDialog : Form
    {
        public bool IsMultSelect {
            get
            {
                return this.treeView1.CheckBoxes;
            }
            set
            {
                this.treeView1.CheckBoxes = value;
            }
        }

        public string Filter
        {
            get
            {
                if (string.IsNullOrEmpty(this.filter))
                {
                    this.filter = "(*.*) | *.* ";
                }
                return filter;
            }

            set
            {
                filter = value;
            }
        }

        public string InitPath
        {
            get
            {
                return initPath;
            }

            set
            {
                initPath = value;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
        }

        public List<string> FileNames
        {
            get
            {
                return fileNames;
            }

            set
            {
                fileNames = value;
            }
        }

        private string filter;
        private string initPath;
        private string fileName;
        private List<string> fileNames;
        public openFileDialog()
        {
            InitializeComponent();
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView_DrawNode);
        }

        private void treeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //隐藏节点前的checkbox
            if (string.IsNullOrEmpty(Path.GetExtension(e.Node.Tag.ToString())) || string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(e.Node.Tag.ToString())))//此处设置前2级节点不显示选择框
                HideCheckBox(this.treeView1, e.Node);
            e.DrawDefault = true;
        }
        private const int TVIF_STATE = 0x8;
        private const int TVIS_STATEIMAGEMASK = 0xF000;
        private const int TV_FIRST = 0x1100;
        private const int TVM_SETITEM = TV_FIRST + 63;
        private void HideCheckBox(TreeView tvw, TreeNode node)
        {

            TVITEM tvi = new TVITEM();

            tvi.hItem = node.Handle;

            tvi.mask = TVIF_STATE;

            tvi.stateMask = TVIS_STATEIMAGEMASK;

            tvi.state = 0;

            SendMessage(tvw.Handle, TVM_SETITEM, IntPtr.Zero, ref tvi);

        }

        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Auto)]

        private struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage; public int cChildren; public IntPtr lParam;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref TVITEM lParam);
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void openFileDialog_Load(object sender, EventArgs e)
        {
            InitFilter();
            PaintTreeView(this.treeView1);
        }
        private Dictionary<string, string[]> dicFiltes = new Dictionary<string, string[]>();
        private void InitFilter()
        {
            dicFiltes.Clear();
            if (!string.IsNullOrEmpty(this.Filter))
            {
                string[] filtes = this.Filter.Split('|');
                if (filtes.Length % 2 != 0)
                    throw new Exception("Filter格式错误");
                for (int i = 0; i < filtes.Length; i=+2)
                {
                    dicFiltes.Add(((filtes[i] + "|" + filtes[(i * 2) + 1])), filtes[(i * 2) + 1].Split(';'));
                }
                this.comFilter.Items.AddRange(dicFiltes.Keys.ToArray());
                this.comFilter.SelectedIndex = 0;
            }
        }

        private void PaintTreeView(TreeView treeView)
        {
            if (string.IsNullOrEmpty(InitPath))
            {
                throw new Exception("初始目录无效");
            }
            if (!Directory.Exists(InitPath))
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
                    DirectoryInfo fDir1 = new DirectoryInfo(f.FullName);
                    FileSystemInfo[] finfos1 = fDir1.GetFileSystemInfos();
                    if (finfos1.Length > 0)
                    {
                        fNode.Nodes.Add(node);
                    }
                    BindChild(node);
                }
                else
                {
                    foreach(var item in dicFiltes[comFilter.Text])
                    {
                        string sitem = item.Trim();
                        if (sitem.Equals("*.*"))
                        {
                            fNode.Nodes.Add(node);
                        }
                        else
                        {
                            string s = sitem.Substring(sitem.IndexOf("*") + 1);
                            if (Path.GetExtension(f.FullName).Equals(s))
                            {
                                fNode.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
        }

        private void comFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaintTreeView(this.treeView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PaintTreeView(this.treeView1);
            if(this.IsMultSelect)
            ClearChecked(this.treeView1.Nodes[0], this.comboBox1.Text);
            this.comboBox1.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode = this.treeView1.Nodes[0];
            if(this.IsMultSelect)
            ClearChecked(this.treeView1.Nodes[0], this.comboBox1.Text);
            this.comboBox1.Text = "";
            this.treeView1.Focus();
        }
        private void ClearChecked(TreeNode fNode,string key)
        {
            if (fNode.Checked)
            {
                fNode.Checked = false;
                if (selectPaths.Keys.Contains(key))
                {
                    selectPaths[key].Add(fNode.Tag.ToString());
                }
                else
                {
                    selectPaths.Add(key, new List<string>() { fNode.Tag.ToString() });
                }
            }
            if(fNode.Nodes.Count > 0)
            {
                for (int i = 0; i < fNode.Nodes.Count; i++)
                {
                    ClearChecked(fNode.Nodes[i], key);
                }
            }
        }
        private Dictionary<string, List<string>> selectPaths = new Dictionary<string, List<string>>();
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                this.comboBox1.Text += "'" + e.Node.Text + "'";
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void openFileDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.DialogResult == DialogResult.OK)
            {
                if (this.IsMultSelect)
                {
                    ClearChecked(this.treeView1.Nodes[0], this.comboBox1.Text);
                    fileNames = new List<string>();
                    foreach (var item in selectPaths[this.comboBox1.Text])
                    {
                        //if (string.IsNullOrEmpty(FileName))
                        //{
                        //    fileName += item;
                        //}
                        //else
                        //{
                        //    fileName += "|" + item;
                        //}
                        fileNames.Add(item);
                    }
                }
            }
            else
            {
                fileName = String.Empty;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!this.IsMultSelect)
            {
                if (!string.IsNullOrEmpty(Path.GetExtension(e.Node.Tag.ToString())) && !string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(e.Node.Tag.ToString())))
                {
                    this.comboBox1.Text = e.Node.Text;
                    //if (!this.selectPaths.ContainsKey(this.comboBox1.Text))
                    {
                        this.fileName = e.Node.Tag.ToString();
                    }
                }
            }
        }
    }
}
