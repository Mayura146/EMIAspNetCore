﻿using Microsoft.AspNetCore.Http;

namespace DatingApp.ServiceModel.DTOs.Response
{
    public class PhotoDto
    {
        public int Id { get; set; }

        public string Url { get; set; }
        public bool IsMain { get; set; }

        public IFormFile formFile { get; set; }
    }
}