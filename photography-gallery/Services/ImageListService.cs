using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace photography_gallery.Services
{
    public class ImageListService
    {
        public ImageListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string[] GetDirectoryList()
        {
            var rootDirectory = Path.Combine(WebHostEnvironment.WebRootPath, "images");
            return Directory.GetDirectories(rootDirectory, "*.*", SearchOption.TopDirectoryOnly);
        }
    }
}
