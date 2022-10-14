namespace myFileDialogDll.UI
{
    partial class openDirectoryDialog
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点8", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点15");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("节点16");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点17");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("节点18");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("节点19");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("节点13", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openDirectoryDialog));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnHomeDir = new System.Windows.Forms.ToolStripButton();
            this.btnCreateDir = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDir = new System.Windows.Forms.ToolStripButton();
            this.btnReflush = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHomeDir,
            this.toolStripSeparator1,
            this.btnCreateDir,
            this.btnDeleteDir,
            this.toolStripSeparator2,
            this.btnReflush,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(429, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "隐藏路径";
            this.toolStripLabel1.ToolTipText = "路径展示";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 25);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 328);
            this.panel2.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "节点1";
            treeNode2.Name = "节点2";
            treeNode2.Text = "节点2";
            treeNode3.Name = "节点3";
            treeNode3.Text = "节点3";
            treeNode4.Name = "节点4";
            treeNode4.Text = "节点4";
            treeNode5.Name = "节点5";
            treeNode5.Text = "节点5";
            treeNode6.Name = "节点6";
            treeNode6.Text = "节点6";
            treeNode7.Name = "节点7";
            treeNode7.Text = "节点7";
            treeNode8.Name = "节点0";
            treeNode8.Text = "节点0";
            treeNode9.Name = "节点9";
            treeNode9.Text = "节点9";
            treeNode10.Name = "节点10";
            treeNode10.Text = "节点10";
            treeNode11.Name = "节点11";
            treeNode11.Text = "节点11";
            treeNode12.Name = "节点12";
            treeNode12.Text = "节点12";
            treeNode13.Name = "节点8";
            treeNode13.Text = "节点8";
            treeNode14.Name = "节点14";
            treeNode14.Text = "节点14";
            treeNode15.Name = "节点15";
            treeNode15.Text = "节点15";
            treeNode16.Name = "节点16";
            treeNode16.Text = "节点16";
            treeNode17.Name = "节点17";
            treeNode17.Text = "节点17";
            treeNode18.Name = "节点18";
            treeNode18.Text = "节点18";
            treeNode19.Name = "节点19";
            treeNode19.Text = "节点19";
            treeNode20.Name = "节点13";
            treeNode20.Text = "节点13";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(429, 328);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Snipaste_2022-09-30_16-32-18.png");
            this.imageList1.Images.SetKeyName(1, "Snipaste_2022-09-30_16-32-03.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnCanel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.lbInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 65);
            this.panel3.TabIndex = 3;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.ForeColor = System.Drawing.Color.Red;
            this.lbInfo.Location = new System.Drawing.Point(24, 28);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            this.lbInfo.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(249, 23);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCanel.Location = new System.Drawing.Point(342, 23);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 2;
            this.btnCanel.Text = "取 消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnHomeDir
            // 
            this.btnHomeDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHomeDir.Image = global::myFileDialogDll.Properties.Resources.首页_home;
            this.btnHomeDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHomeDir.Name = "btnHomeDir";
            this.btnHomeDir.Size = new System.Drawing.Size(23, 22);
            this.btnHomeDir.Text = "toolStripButton1";
            this.btnHomeDir.ToolTipText = "根目录";
            this.btnHomeDir.Click += new System.EventHandler(this.btnHomeDir_Click);
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreateDir.Image = global::myFileDialogDll.Properties.Resources.创建_newlybuild1;
            this.btnCreateDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(23, 22);
            this.btnCreateDir.Text = "toolStripButton2";
            this.btnCreateDir.ToolTipText = "创建文件夹";
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteDir.Image = global::myFileDialogDll.Properties.Resources.删除_delete_two;
            this.btnDeleteDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteDir.Text = "toolStripButton3";
            this.btnDeleteDir.ToolTipText = "删除文件夹";
            this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
            // 
            // btnReflush
            // 
            this.btnReflush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReflush.Image = global::myFileDialogDll.Properties.Resources.刷新_refresh;
            this.btnReflush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReflush.Name = "btnReflush";
            this.btnReflush.Size = new System.Drawing.Size(23, 22);
            this.btnReflush.Text = "toolStripButton4";
            this.btnReflush.ToolTipText = "刷新";
            this.btnReflush.Click += new System.EventHandler(this.btnReflush_Click);
            // 
            // openDirectoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "openDirectoryDialog";
            this.Text = "选择路径";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.openDirectoryDialog_FormClosed);
            this.Load += new System.EventHandler(this.openDirectoryDialog_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHomeDir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCreateDir;
        private System.Windows.Forms.ToolStripButton btnDeleteDir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnReflush;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnOK;
    }
}