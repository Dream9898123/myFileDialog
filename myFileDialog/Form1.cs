using myFileDialogDll.Manager;
using myFileDialogDll.Manager.Factorys;
using myFileDialogDll.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace myFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openDirectoryDialog openDirectoryDialog = new openDirectoryDialog();
            openDirectoryDialog.InitPath = Path.Combine(Directory.GetCurrentDirectory(), "根目录");
            Directory.CreateDirectory(openDirectoryDialog.InitPath);
            openDirectoryDialog.ShowDialog();
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            ////FolderNameEditor folderBrowserDialog1 = new FolderNameEditor();
            //fbd.ShowDialog(this);
        }

        private void uiTreeView1_Click(object sender, EventArgs e)
        {

        }

        private void uiTreeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //如果按照默认实现来绘制，就这样做
            if (e.Node.Level > 0)
            {
                e.DrawDefault = true;
                return;
            }
            //绘制的工作就完全是GDI+的那一套了
            LinearGradientMode mode = LinearGradientMode.Vertical;
            Rectangle rect = e.Bounds;
            ////绘制渐变背景
            //using (LinearGradientBrush brush = new LinearGradientBrush(rect, _startColor, _endColor, mode))
            //{
            //    e.Graphics.FillRectangle(brush, rect);
            //}
            Font nodeFont = this.Font;
            //绘制加减号，做了一些硬编码
            e.Graphics.DrawImage((e.Node.IsExpanded ? imageList1.Images[0] : imageList1.Images[1]), e.Bounds.Location.X + 5, e.Bounds.Location.Y + 3);
            //绘制文字
            e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.Black, (e.Bounds.Location.X + 20), (e.Bounds.Location.Y));
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //如果按照默认实现来绘制，就这样做
            if (e.Node.Level > 0)
            {
                e.DrawDefault = true;
                return;
            }
            //绘制的工作就完全是GDI+的那一套了
            LinearGradientMode mode = LinearGradientMode.Vertical;
            Rectangle rect = e.Bounds;
            ////绘制渐变背景
            //using (LinearGradientBrush brush = new LinearGradientBrush(rect, _startColor, _endColor, mode))
            //{
            //    e.Graphics.FillRectangle(brush, rect);
            //}
            Font nodeFont = this.Font;
            //绘制加减号，做了一些硬编码
            e.Graphics.DrawImage((e.Node.IsExpanded ? imageList1.Images[0] : imageList1.Images[1]), e.Bounds.Location.X + 5, e.Bounds.Location.Y + 3);
            //绘制文字
            e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.Black, (e.Bounds.Location.X + 20), (e.Bounds.Location.Y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog openFileDialog = new openFileDialog();
            openFileDialog.InitPath = Path.Combine(Directory.GetCurrentDirectory(), "根目录");
            openFileDialog.Filter = "(*.txt) | *.txt";
            openFileDialog.IsMultSelect = false;
            openFileDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.InitialDirectory = Environment.CurrentDirectory;
                ofd.Filter = "(*.txt) | *.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyFileManager.GetInstance().ReSetFactory(new DialogFilesFactory());
            MyFileManager.GetInstance().ProjectName = "Test";
            string sPath = MyFileManager.GetInstance().GetDirPath("(*.txt) | *.txt");
            Console.WriteLine(sPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sPath = MyFileManager.GetInstance().GetFileFullName("(*.txt) | *.txt");
            Console.WriteLine(sPath);
        }
    }
}
