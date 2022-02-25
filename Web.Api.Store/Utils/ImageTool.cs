using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Web.Api.Store.Utils
{
    public static class ImageTool
    {

        public static string SaveImage(string data, string host)
        {
            if (!string.IsNullOrEmpty(data))
            {
                String path = Path.Combine(Directory.GetCurrentDirectory(), "Files/Uploads/");
            
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                //Create the Directory.
                string imageName = Guid.NewGuid() + ".png";

                string imgPath = Path.Combine(path, imageName);
              

                if (data.Contains("data:image"))
                {
                    data = data.Substring(data.LastIndexOf(',') + 1);
                }

                byte[] imageBytes = Convert.FromBase64String(data);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                image.Save(imgPath, ImageFormat.Png);

                return imageName;
            }
            return "";
        }

        public static string GetBase64ByUrl(string url)
        {
            String path = Path.Combine(Directory.GetCurrentDirectory());

            string imgPath = Path.Combine(path, "Files/Uploads/" +url);

            var bytesImagen = System.IO.File.ReadAllBytes(imgPath);
            var imagenBase64 = Convert.ToBase64String(bytesImagen);

            return imagenBase64;
        }


    }
}
