using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CET322Assignment2.Models
{
	public class Book
	{
        [DisplayName("Book ID")]
        public int Id { get; set; }

        [DisplayName("Book Name")]
        public string Title { get; set; }
        public string Description { get; set; }

        [DisplayName("Author")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Publish Date")]
        [Required]
        public DateTime PublishDate { get; set; }

        [DisplayName("Page Size")]
        public int PageSize { get; set; }

        public Decimal Price { get; set; }
    }
}

