using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFileDialogDll.Manager
{
    public interface IFilesFactory
    {
        string GetFileFullName(string initPath, string filter);
        List<string> GetFileFullNames(string initPath, string filter);
        string GetDirFullName(string initPath);
    }
}
