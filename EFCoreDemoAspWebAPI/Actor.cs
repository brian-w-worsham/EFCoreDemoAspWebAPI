using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemoAspWebAPI
{
    public class Actor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Biography { get; set; }

       // [Column(TypeName = "Date")]
        public DateTime? Dob  { get; set; }   


    }
}
