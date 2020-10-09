using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.DataModel.Entities
{
   public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte [] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}
