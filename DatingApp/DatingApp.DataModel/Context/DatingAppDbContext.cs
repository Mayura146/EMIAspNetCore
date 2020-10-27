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
        public DbSet<UserLike> Like { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserLike>()
                .HasKey(key => new { key.SourceUserId, key.LikedUserId });
            modelBuilder.Entity<UserLike>()
                .HasOne(s => s.SourceUser)
                .WithMany(l => l.LikedUsers)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserLike>()
                .HasOne(l => l.LikedUser)
                .WithMany(l => l.LikedByUsers)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
