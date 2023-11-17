using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookServiceWEBAPI.Entities
{
    [Table("Books")]
    public class Book
    {

        [Key]
        public int BookID { get; set; }

        [Required]
        [StringLength(100)]
        [Column("BookName", TypeName = "varchar")]
        public string? BookName { get; set; }

        [Required]
        [Column(TypeName = "INT")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Author", TypeName = "varchar")]
        public string? Author { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Lang", TypeName = "varchar")]
        public string? Lang { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column("ReleaseDate", TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
    }
}

