namespace VideoGameStore.Models
{
    public class Publisher
    {
        public Publisher() => Games = new HashSet<Game>();

        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public string WebURL { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}