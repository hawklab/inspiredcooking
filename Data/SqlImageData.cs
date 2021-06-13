using System.Collections.Generic;
using InspiredCooking.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using Azure.Storage.Blobs;
using System.Threading.Tasks;

namespace InspiredCooking.Data
{
    public class SqlImageData : IImageData
    {
        private readonly InspiredCookingDbContext db;

        public SqlImageData(InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public async Task<Uri> UploadImageAsync(IFormFile newImageFile)
        {
            string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            //Create a unique name for the container
            string containerName = "images";

            // Create the container and return a container client object
            BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);

            // Create a local file in the ./data/ directory for uploading and downloading
            string fileName = Guid.NewGuid().ToString() + newImageFile.FileName;

            // Get a reference to a blob
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            // Upload image to blob storage
            using (var stream = newImageFile.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }

            // Return the URL image
            return blobClient.Uri;
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