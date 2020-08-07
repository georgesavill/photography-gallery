using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using photography_gallery.Models;

namespace photography_gallery.Services
{
    public class ImageListService
    {
        public ImageListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public List<ListEntry> GetDirectoryList(string subDirectory)
        {
            List<ListEntry> returnedDirectoryList = new List<ListEntry>(); 
            string rootDirectory = Path.Combine(WebHostEnvironment.WebRootPath, "images") + subDirectory;
            string[] directoryList = Directory.GetDirectories(rootDirectory, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string entry in directoryList)
            {
                returnedDirectoryList.Add(new ListEntry(entry, entry.Split("wwwroot").Last(), entry.Split("/").Last(), "dir"));
            }
            return returnedDirectoryList;
        }
        public List<ListEntry> GetFileList(string subDirectory)
        {
            List<ListEntry> returnedFileList = new List<ListEntry>();
            string rootDirectory = Path.Combine(WebHostEnvironment.WebRootPath, "images") + subDirectory;
            string[] fileList = Directory.GetFiles(rootDirectory, "*.jpg", SearchOption.TopDirectoryOnly);
            foreach (string entry in fileList)
            {
                returnedFileList.Add(new ListEntry(entry, entry.Split("wwwroot").Last(), entry.Split("/").Last(), "file"));
            }
            return returnedFileList;
        }
    }
}
