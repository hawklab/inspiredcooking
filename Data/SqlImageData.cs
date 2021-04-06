using System.Collections.Generic;
using InspiredCooking.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace InspiredCooking.Data
{
    public class SqlImageData : IImageData
    {
        private readonly InspiredCookingDbContext db;

        public SqlImageData(InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public Image UploadImage(IFormFile newImageFile)
        {
            var newImage = new Image();
            newImage.ImageTitle = newImageFile.FileName;
            var ms = new MemoryStream();
            newImageFile.CopyTo(ms);
            newImage.ImageData = ms.ToArray();
            
            db.Add(newImage);
            db.SaveChanges();
            
            return newImage;
        }

        public Image GetById(int id)
        {
            return db.Images.Where(i => i.Id == id)
                            .First();
        }
    }
}