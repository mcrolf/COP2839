namespace VideoGameStore.Models
{
    public class GameListViewModel
    {
        public IEnumerable<Game> Games { get; set; } = new List<Game>();
        public GameGridData CurrentRoute { get; set; } = new GameGridData();
        public int TotalPages { get; set; } 
    }
}
