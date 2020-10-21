using DatingApp.DataModel.Context;
using DatingApp.DataModel.Entities;
using DatingApp.DataModel.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataModel.Repositories
{
   public class UserRepository:IUserRepository
    {

        private readonly DatingAppDbContext _datingAppDbcontext;

        public UserRepository(DatingAppDbContext datingAppDbContext)
        {
            _datingAppDbcontext = datingAppDbContext;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _datingAppDbcontext.User.Include(x=>x.Photos).ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _datingAppDbcontext.User.Where(u=> u.Id == id).Include(x=>x.Photos).FirstOrDefaultAsync();
        }
    }
}
