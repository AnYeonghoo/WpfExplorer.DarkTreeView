using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorer.Forms.Local.Helpers
{
    public class DirectoryManager
    {
        public string DownloadDirectory { get; init; }
        public string DocumentDirectory { get; init; }
        public string PictureDirectory { get; init; }
        public  DirectoryManager()
        {
            var userPath = Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile);

            DownloadDirectory = Path.Combine(userPath, "Download");
            DocumentDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
            PictureDirectory = Environment.GetFolderPath(
                Environment.SpecialFolder.MyPictures);
        }
    }
}

