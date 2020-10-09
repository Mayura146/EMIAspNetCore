using DatingApp.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.DataModel.Context
{
    public class DatingAppDbContext:DbContext
    {
        public DatingAppDbContext(DbContextOptions <DatingAppDbContext> options):base (options)
        { }

        public DbSet<User> User { get; set; }
    }
}
