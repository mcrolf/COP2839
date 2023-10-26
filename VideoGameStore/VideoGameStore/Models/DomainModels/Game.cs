namespace VideoGameStore.Models
{
    /*
     * Demonstration of enum. This is not the best field for using a enum
     * but it does display how enums generally work
     */
    public enum Platform
    {
        Playstation,
        Playstation_4,
        Playstation_5,
        Xbox,
        Nintendo,
        Ninetndo_Switch,
        Computer
    }

    public class Game
    {
       
        /*
         * Fields are mapped and declared using the data types in C#
         * When we use the command line in EF core the lib will
         * create SQL statements based on how we define our Models
         * 
         * Notice the fields that map to the ERD
         */
        public int GameID { get; set; }
        // Title should not be a nullable field the =null! tells the compiler the programer will ensure Title is not null
        public string Title { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public Platform Platform { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        /*
         * Here is how we define the realtionship in our entites.
         * There can be many Genre entries in our Game table, but only one Genre per Game. 
         * 
         * Obviously we could alter the relationship if deisgn required-meaning multiple genres
         * for a game, but for now we will keep a one to many relationship
         * 
         * The Publisher Entity is also a one to many relationship.
         * 
         * In the examples below GenreID, and GenreID represent the foreign key properties
         * the Genre and Publisher properties are known as Navigation properties 
         */

        //Foreign Key
        public int GenreID { get; set; }
        //Navigation Property
        public Genre Genre { get; set; } = null!;

        //Foreign Key
        public int PublisherID { get; set; }
        //Navigation Property 
        public Publisher Publisher { get; set; } = null!;

    }
}
