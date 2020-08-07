using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photography_gallery.Models
{
    public class ListEntry
    {
        private string fullPath;
        private string relativePath;
        private string displayName;
        private string type;

        public ListEntry (string fullPath, string relativePath, string displayName, string type)
        {
            this.fullPath = fullPath;
            this.relativePath = relativePath;
            this.displayName = displayName;
            this.type = type;
        }

        public string FullPath
        {
            get { return fullPath; }
            set { fullPath = value; }
        }

        public string RelativePath
        {
            get { return relativePath; }
            set { relativePath = value; }
        }
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
