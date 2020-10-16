using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.ServiceModel.DTOs.Request
{
   public class RegisterDto
    {
        public string Name { get; set; }

        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
