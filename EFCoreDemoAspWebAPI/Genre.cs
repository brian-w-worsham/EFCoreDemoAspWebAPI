using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemoAspWebAPI
{
    [Table(name: "GenresTbl", Schema = "movies")]
    public class Genre
    {
        [Key]
        public int Identifier { get; set; }

        // [StringLength(150)]

        [Required]
        [Column("GenreName")]
        public string Name { get; set; }
    }
}
