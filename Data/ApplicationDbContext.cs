using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskLists.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Item> Items { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
