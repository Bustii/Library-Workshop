using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Models
{
    public class Category
    {
        [Comment("Primary Key")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of the category")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public List<Book> Books { get; set; } = new List<Book>();
    }

    //      Has Id – a unique integer, Primary Key
    //    • Has Name – a string with min length 5 and max length 50 (required)
    //    • Has Books – a collection of type Books
}
