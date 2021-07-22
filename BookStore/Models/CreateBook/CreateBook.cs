using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.CreateBook
{
    public class CreateBook
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        [MaxLength(500)]
        public string BookName { get; set; }
        [Required]
        [MaxLength(300)]
        public string Authors { get; set; }
        [Required]
        public int PublishYear { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        
        [MaxLength(300)]
        public IFormFile Photo { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
