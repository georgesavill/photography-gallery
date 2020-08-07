using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace photography_gallery.Services
{
    [ApiController]
    [Route("/uploadImages")]
    public class ImageUpload : ControllerBase
    {
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            Console.WriteLine("Photo uploaded:");
            Console.WriteLine(file.FileName);
            return Ok();
        }
    }
}
