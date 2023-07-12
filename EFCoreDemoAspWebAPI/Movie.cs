using Microsoft.EntityFrameworkCore;

namespace EFCoreDemoAspWebAPI
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime ReleaseDate { get; set; }

        // [Unicode(false)]
        public string PosterURL { get; set; }
    }
}
