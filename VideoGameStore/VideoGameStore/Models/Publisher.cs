namespace VideoGameStore.Models
{
    public class Publisher
    {
        public Publisher() => Publishers = new HashSet<Publisher>();
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public string WebURL { get; set; }
        public ICollection<Publisher> Publishers { get; set;}
    }
}
