namespace VideoGameStore.Models
{
    public class Genre
    {
        public Genre() => Games = new HashSet<Game>();

        public int GenreID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}