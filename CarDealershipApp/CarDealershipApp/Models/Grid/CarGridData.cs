using System.Text.Json.Serialization;

namespace CarDealershipApp.Models
{
    public class CarGridData : GridData
    {
        public CarGridData() => SortField = nameof(Car.Year);

        [JsonIgnore]
        public bool IsSortByManufacturer => SortField.EqualsNoCase(nameof(Car.Manufacturer.Name));

        [JsonIgnore]
        public bool IsSortByModel => SortField.EqualsNoCase(nameof(Car.CarModel));

        [JsonIgnore]
        public bool IsSortByPrice => SortField.EqualsNoCase(nameof(Car.StickerPrice));
    }
}
