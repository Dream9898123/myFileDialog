namespace myFileDialogDll.UI
{
    partial class openFileDialog
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
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode106,
            treeNode107,
            treeNode108,
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("节点14");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("节点18");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("节点19");
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("节点15", new System.Windows.Forms.TreeNode[] {
            treeNode113,
            treeNode114});
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("节点16");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("节点17");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode115,
            treeNode116,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("节点13");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.comFilter = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            treeNode101.Name = "节点7";
            treeNode101.Text = "节点7";
            treeNode102.Name = "节点8";
            treeNode102.Text = "节点8";
            treeNode103.Name = "节点9";
            treeNode103.Tag = "1";
            treeNode103.Text = "节点9";
            treeNode104.Name = "节点10";
            treeNode104.Text = "节点10";
            treeNode105.Name = "节点11";
            treeNode105.Text = "节点11";
            treeNode106.Name = "节点3";
            treeNode106.Text = "节点3";
            treeNode107.Name = "节点4";
            treeNode107.Tag = "1";
            treeNode107.Text = "节点4";
            treeNode108.Name = "节点5";
            treeNode108.Text = "节点5";
            treeNode109.Name = "节点6";
            treeNode109.Text = "节点6";
            treeNode110.Name = "节点0";
            treeNode110.Tag = "1";
            treeNode110.Text = "节点0";
            treeNode111.Name = "节点1";
            treeNode111.Tag = "1";
            treeNode111.Text = "节点1";
            treeNode112.Name = "节点14";
            treeNode112.Text = "节点14";
            treeNode113.Name = "节点18";
            treeNode113.Text = "节点18";
            treeNode114.Name = "节点19";
            treeNode114.Text = "节点19";
            treeNode115.Name = "节点15";
            treeNode115.Text = "节点15";
            treeNode116.Name = "节点16";
            treeNode116.Text = "节点16";
            treeNode117.Name = "节点17";
            treeNode117.Text = "节点17";
            treeNode118.Name = "节点2";
            treeNode118.Text = "节点2";
            treeNode119.Name = "节点12";
            treeNode119.Text = "节点12";
            treeNode120.Name = "节点13";
            treeNode120.Text = "节点13";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode110,
            treeNode111,
            treeNode118,
            treeNode119,
            treeNode120});
            this.treeView1.Size = new System.Drawing.Size(498, 335);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.comFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::myFileDialogDll.Properties.Resources.首页_home;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "根目录";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::myFileDialogDll.Properties.Resources.刷新_refresh;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "刷新";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // comFilter
            // 
            this.comFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(121, 25);
            this.comFilter.SelectedIndexChanged += new System.EventHandler(this.comFilter_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCanel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 65);
            this.panel1.TabIndex = 3;
            // 
            // btnCanel
            // 
            this.btnCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCanel.Location = new System.Drawing.Point(392, 21);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(75, 23);
            this.btnCanel.TabIndex = 4;
            this.btnCanel.Text = "取 消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(299, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(498, 25);
            this.comboBox1.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "openFileDialog";
            this.Text = "文件选择器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.openFileDialog_FormClosed);
            this.Load += new System.EventHandler(this.openFileDialog_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripComboBox comFilter;
    }
}