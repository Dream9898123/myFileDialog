using myFileDialogDll.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFileDialogDll.Manager.Factorys
{
    public class DialogFilesFactory : IFilesFactory
    {
        public string GetDirFullName(string initPath)
        {
            openDirectoryDialog openDirectoryDialog = new openDirectoryDialog();
            openDirectoryDialog.InitPath = initPath;
            if (openDirectoryDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openDirectoryDialog.SelectPath;
            }
            else
                return null;
        }

        public string GetFileFullName(string initPath,string filter)
        {
            openFileDialog openFileDialog = new openFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.IsMultSelect = false;
            openFileDialog.InitPath = initPath;
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetFileFullNames(string initPath,string filter)
        {
            openFileDialog openFileDialog = new openFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.IsMultSelect = true;
            openFileDialog.InitPath = initPath;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.FileNames;
            }
            else
            {
                return null;
            }
        }
    }
}
