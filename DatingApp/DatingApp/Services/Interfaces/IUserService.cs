using DatingApp.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Api.Services.Interfaces
{
  public  interface IUserService
    {

        Task<IEnumerable<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);
    }
}
