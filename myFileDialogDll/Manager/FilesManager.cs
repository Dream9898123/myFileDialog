using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace myFileDialogDll.Manager
{
    public abstract class FilesManager
    {
        private string projectInitPath = Path.Combine(Directory.GetCurrentDirectory(),"Project");
        public virtual void ReSetFactory(IFilesFactory filesFactory)
        {
            this._filesFactory = filesFactory;
        }
        public virtual string GetFileFullName(string filter)
        {
            string initfiltPath = GetfilterDirByFilter(filter);
            return this._filesFactory.GetFileFullName(initfiltPath, filter);
        }
        public virtual List<string> GetFileFullNames(string filter)
        {
            string initfiltPath = GetfilterDirByFilter(filter);
            return this._filesFactory.GetFileFullNames(initfiltPath, filter);
        }
        public virtual string GetDirPath(string filter)
        {
            string initfiltPath = GetfilterDirByFilter(filter);
            return this._filesFactory.GetDirFullName(initfiltPath);
        }

        public string GetfilterDirByFilter(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                throw new Exception("后缀不能为空");
            string filterDir = filter.Split('|')[1].Substring(filter.IndexOf('*') + 1);

            string initfiltPath = Path.Combine(ProjectPath, filterDir);
            if (!Directory.Exists(initfiltPath))
                Directory.CreateDirectory(initfiltPath);
            return initfiltPath;
        }

        private IFilesFactory _filesFactory;
        private string _projectName;
        public string ProjectPath
        {
            get
            {
                return Path.Combine(projectInitPath, ProjectName);
            }
        }
        public string ProjectName
        {
            get
            {
                return _projectName;
            }

            set
            {
                _projectName = value;
            }
        }
    }
}
