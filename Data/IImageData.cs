using System;
using System.Threading.Tasks;
using InspiredCooking.Core;
using Microsoft.AspNetCore.Http;

namespace InspiredCooking.Data
{
    public interface IImageData
    {
        Image UploadImage(IFormFile newImage);
        Task<Uri> UploadImageAsync(IFormFile newImageFile);
        Image GetById(int id);
    }
}
