using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Models;

namespace tr.Repository.AppDbContext
{
    public class trDbContext : DbContext
    {
        public trDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasOne<User>(x => x.User).WithMany(x => x.Posts).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "ozan", Password = "database123", Username = "ozan123" });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, UserId = 1, Content = "havalarin isinmasi kuresel isinmanin habercisidir", Title = "kuresel isinma" });

        }
    }
}
