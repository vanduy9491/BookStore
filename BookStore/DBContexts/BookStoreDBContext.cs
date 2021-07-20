using BookStore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBContexts
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions options) : base(options)
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
        }
    }
}
