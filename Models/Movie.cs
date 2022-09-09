using System.ComponentModel.DataAnnotations;

namespace asp_razor.Models
{
    public class Movie
    {
        public int ID { get; set; } // Primary key in db
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
