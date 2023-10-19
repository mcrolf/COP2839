namespace VideoGameStore.Models //includes all classes in model
{
    //****************************
    // enum for platform types
    //****************************
    public enum PLatform
    {
        PLaystation_3,
        Playstation_4,
        Playstation_5,
        Xbox,
        Nintendo_Switch,
        PC
    }

    public class Game
    {
        //****************************
        // declared fields
        //****************************
        public int GameID {  get; set; }
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public PLatform PLatform { get; set; }
        public decimal? Price { get; set; }
        public int StockQuantity { get; set; }

        //******************************
        // defining entity relationships
        //******************************
        public int GenreID { get; set; }
        public Genre Genre { get; set; } = null!;
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } = null!;
    }
}
