﻿using BookStore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBContexts
{
    public class BookStoreDBContext : IdentityDbContext<AppIdentityUser>
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CatygoryName = "Khoa học viễn tưởng",
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 2,
                    CatygoryName = "Giáo khoa",
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 3,
                    CatygoryName = "Tham khảo",
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 4,
                    CatygoryName = "Truyện tranh",
                    IsDeleted = false
                }
                );
            modelBuilder.Entity<Book>().HasData(
               new Book()
               {
                   BookId = 1,
                   BookName = "Doraemon",
                   Authors = "Nam Thư",
                   PublishYear = 2000,
                   Price = 10000,
                   Description = "Truyện về chú mèo máy Doraemon",
                   IsDeleted = false,
                   CategoryId = 4,
                   Photo = "images/no-photo.jpg"
               },
                new Book()
                {
                    BookId = 2,
                    BookName = "Tiếng Anh 12",
                    Authors = "Bửu Ngọc",
                    PublishYear = 2000,
                    Price = 12000,
                    Description = "Sách giáo khoa Tiếng Anh",
                    IsDeleted = false,
                    CategoryId = 2,
                    Photo = "images/no-photo.jpg"
                });
            SeedingAspNetUser(modelBuilder);
            SeedingAspNetRole(modelBuilder);
            SeedingAspNetUserRole(modelBuilder);
        }

        private void SeedingAspNetUser(ModelBuilder modelBuilder)
        {
            AppIdentityUser user = new AppIdentityUser()
            {
                Id = "2c0fca4e-9376-4a70-bcc6-35bebe497866",
                UserName = "khoa.nguyen@codegym.vn",
                Email = "khoa.nguyen@codegym.vn",
                NormalizedEmail = "khoa.nguyen@codegym.vn",
                NormalizedUserName = "khoa.nguyen@codegym.vn",
                LockoutEnabled = false,
                Avatar = "/images/khoanguyen.jpg"
            };
            PasswordHasher<AppIdentityUser> passwordHasher = new PasswordHasher<AppIdentityUser>();
            var passwordHash = passwordHasher.HashPassword(user, "Asdf1234!");
            user.PasswordHash = passwordHash;

            modelBuilder.Entity<AppIdentityUser>().HasData(user);
        }

        private void SeedingAspNetRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "c0c6661b-0964-4e62-8083-3cac6a6741ec",
                    Name = "SystemAdmin",
                    NormalizedName = "SystemAdmin",
                    ConcurrencyStamp = "1"
                });
        }
        private void SeedingAspNetUserRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "c0c6661b-0964-4e62-8083-3cac6a6741ec",
                    UserId = "2c0fca4e-9376-4a70-bcc6-35bebe497866"
                });
        }
    }
}
