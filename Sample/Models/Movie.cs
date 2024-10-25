using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required, MaxLength(100)]
        public required string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public required string Genre { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
