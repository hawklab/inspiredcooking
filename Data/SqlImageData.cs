using System.Collections.Generic;
using InspiredCooking.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InspiredCooking.Data
{
    public class SqlImageData : IImageData
    {
        private readonly InspiredCookingDbContext db;

        public SqlImageData(InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public Image UploadImage(Image newImage)
        {
            db.Add(newImage);
            return newImage;
        }
    }
}