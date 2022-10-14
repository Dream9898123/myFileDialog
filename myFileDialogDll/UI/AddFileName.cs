using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myFileDialogDll.UI
{
    public partial class AddFileName : Form
    {
        public AddFileName()
        {
            InitializeComponent();
        }
        private string createPath;
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.btnOk.Enabled = !string.IsNullOrEmpty(this.txtName.Text);
            if (string.IsNullOrEmpty(txtName.Text))
            {
                this.lbInfo.Text = "";
                return;
            }
            string createPat = Path.Combine(CreatePath,this.txtName.Text);
            if (Directory.Exists(createPat))
            {
                this.lbInfo.Text = "已存在";
                this.btnOk.Enabled = false;
            }
            else
            {
                this.lbInfo.Text = "";
                this.btnOk.Enabled = true;
            }

        }

        public string CreatePath
        {
            get
            {
                return createPath;
            }

            set
            {
                createPath = value;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.CreatePath = Path.Combine(CreatePath, this.txtName.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
