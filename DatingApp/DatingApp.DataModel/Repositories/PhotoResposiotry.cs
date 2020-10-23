using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DatingApp.Api.Helper;
using DatingApp.DataModel.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataModel.Repositories
{
    public class PhotoResposiotry : IPhotoRepository
    {
        private readonly Cloudinary _cloudinary;
        public PhotoResposiotry(IOptions<CloudinarySettings> options)
        {
            var account = new Account(
                options.Value.CloudName,
                options.Value.ApiKey,
                options.Value.ApiSecret

                );

            _cloudinary = new Cloudinary(account);
        }
        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile formFile)
        {
            var uploadResult = new ImageUploadResult();
            if(formFile.Length > 0)
            {
                var stream = formFile.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(formFile.FileName, stream),
                    Transformation = new Transformation().Height(300).Width(300).Crop("fill").Gravity("face")
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }
            return uploadResult;
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            var delete = new DeletionParams(publicId);
            var response = await _cloudinary.DestroyAsync(delete);
            return response;
        }
    }
}
