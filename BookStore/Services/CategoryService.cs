using BookStore.DBContexts;
using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly BookStoreDBContext context;
        public CategoryService(BookStoreDBContext context)
        {
            this.context = context;
        }

        public List<Category> GetCategories()
        {
            return context.Categories.Where(c => c.IsDeleted == false).ToList();
        }
    }
}
