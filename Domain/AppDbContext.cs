using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                UserId = "25DC686E-5D5C-45E5-AF8C-64E10600055B"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("30A389FC-F1E4-4B5D-819A-70D1E50AFE92"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("728727B7-FD56-4D30-B8F8-9DC71E699F8A"),
                CodeWord = "PageServices",
                Title = "Our Services"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("210EDBB6-7BB7-4314-A13C-BE92809FE020"),
                CodeWord = "PageContacts",
                Title = "Our Contacts"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("B4A827B2-189E-4A1A-B033-936607096BA2"),
                CodeWord = "PageNews",
                Title = "Our News"
            });
        }
    }
}
