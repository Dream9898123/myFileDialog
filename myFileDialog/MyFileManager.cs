using myFileDialogDll.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFileDialog
{
    public class MyFileManager : FilesManager
    {
        private static object syncObj = new object();
        private static MyFileManager instance = null;
        public static MyFileManager GetInstance()
        {
            lock (syncObj)
            {
                if (instance == null)
                    instance = new MyFileManager();
            }
            return instance;
        }
    }
}
