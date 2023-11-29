using VideoGameStore.Models;

namespace VideoGameStore.Areas.Admin.Models
{
    public class GameViewModel
    {
        public Game game { get; set; } = new Game();

        //public int[] selectedPublishers { get; set; } = Array.Empty<int>();
        public IEnumerable<Publisher> publishers { get; set; } = new List<Publisher>();

        //public int[] selectedGenres { get; set; } = Array.Empty<int> ();
        public IEnumerable<Genre> genres { get; set; } = new List<Genre>();
    }
}
