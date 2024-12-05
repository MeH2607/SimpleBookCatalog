using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBookCatalog.Domain.Enums;

namespace SimpleBookCatalog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Include a valid string")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Include a valid string")]
        [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage = "Please select a category")]
        public Category Category { get; set; }
    }
}
