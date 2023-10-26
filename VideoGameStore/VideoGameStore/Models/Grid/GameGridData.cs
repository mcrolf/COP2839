using System.Text.Json.Serialization;

namespace VideoGameStore.Models
{
    public class GameGridData : GridData
    {
        public GameGridData() => SortField = nameof(Game.Title);
        
        [JsonIgnore]
        public bool IsSortByGenre => SortField.EqualsNoCase(nameof(Game.Genre));

        [JsonIgnore]
        public bool IsSortByPublisher => SortField.EqualsNoCase(nameof(Game.Publisher));

        [JsonIgnore]
        public bool IsSortByPrice => SortField.EqualsNoCase(nameof(Game.Price));
    }
}
