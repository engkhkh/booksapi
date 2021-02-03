using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

#nullable disable

namespace BooksAPI.Models
{
    public partial class Book
    {
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Author { get; set; }
        [BindProperty]
        public int? NumberOfPages { get; set; }
        [BindProperty]
        public DateTime? PublishedAt { get; set; }
    }
}
