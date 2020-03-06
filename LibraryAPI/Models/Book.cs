using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Book Title", Prompt = "Please add book title", Description = "The title of a book" )]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Book Author", Prompt = "Please add book author", Description = "The author of a book")]
        public string Author { get; set; }
    }
}
