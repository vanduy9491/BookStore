using BookStore.Entities;
using BookStore.Models.CreateBook;
using BookStore.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IBookService bookService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public DashboardController(ICategoryService categoryService,
                                    IBookService bookService,
                                    IWebHostEnvironment webHostEnvironment)
        {
            this.categoryService = categoryService;
            this.bookService = bookService;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(bookService.GetBooks());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = categoryService.GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBook book)
        {
            if (ModelState.IsValid)
            {
                string filename = "no-photo.jpg";
                if (book.Photo != null)
                {
                    string folderPath = Path.Combine(webHostEnvironment.ContentRootPath, @"wwwroot\images");
                    filename = $"{DateTime.Now.ToString("ddMMyyyyhhmmss")}_{book.Photo.FileName}";
                    string fullPath = Path.Combine(folderPath, filename);
                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        book.Photo.CopyTo(file);
                    }
                }
                var newBook = new Book()
                {
                    Photo = $"/images/{filename}",
                    BookName = book.BookName,
                    Authors = book.Authors,
                    Description = book.Description,
                    IsDeleted = book.IsDeleted,
                    CategoryId = book.CategoryId,
                    PublishYear = book.PublishYear,
                    Price = book.Price,
                    Category = categoryService.GetCategories().FirstOrDefault(c => c.CategoryId == book.CategoryId)
                };
                bookService.Create(newBook);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
