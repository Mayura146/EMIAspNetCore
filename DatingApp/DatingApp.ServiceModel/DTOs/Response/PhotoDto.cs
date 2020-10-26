using Microsoft.AspNetCore.Http;

namespace DatingApp.ServiceModel.DTOs.Response
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public IFormFile File { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}