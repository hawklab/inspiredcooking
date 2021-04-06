using InspiredCooking.Core;
using Microsoft.AspNetCore.Http;

namespace InspiredCooking.Data
{
    public interface IImageData
    {
        Image UploadImage(IFormFile newImage);
        Image GetById(int id);
    }
}
