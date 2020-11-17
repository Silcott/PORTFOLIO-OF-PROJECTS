using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BookStore_API.Data
{
    [Table("Books")]
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }//?nullable
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }//?nullable

        public int? AuthorId { get; set; }//?nullable
        public virtual Author Author { get; set; } 
    }
}