//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using SixLabors.ImageSharp;
//using SixLabors.ImageSharp.Processing;

//namespace photography_gallery.Services
//{
//    [ApiController]
//    [Route("/uploadImages")]
//    public class ImageUpload : ControllerBase
//    {
//        [HttpPost]
//        public IActionResult Upload(IFormFile file)
//        {
//            using var image = Image.Load(file.OpenReadStream());

//            image.Mutate(x => x.Resize(315, 315));

//            string uploadedImageName = file.FileName.Split(".").First();
//            string uploadedImageExtension = file.FileName.Split(".").Last();
//            image.Save("./wwwroot/images/uploaded/" + uploadedImageName + "_thumbnail." + uploadedImageExtension);

//            return Ok();
//        }
//    }
//}
