using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace FutureValueCalculator.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please Enter a Monthly Investment...")]
        [Range(1, 500, ErrorMessage = "Monthly Investment must be between 1 and 500...")]
        public decimal? MonthlyInvestment {  get; set; }

        [Required(ErrorMessage = "Please Enter a Yearly Intrest Rate...")]
        [Range(0.1, 10, ErrorMessage = "Yearly Rate must be between 0.1 and 10")]
        public decimal? YearlyIntrestRate { get; set; }

        [Required(ErrorMessage = "Please Enter the number of Years...")]
        [Range(1, 50, ErrorMessage = "Number of Years must be between 1 and 50...")]
        public int? Years { get; set; }

        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterstRate = YearlyIntrestRate / 12 / 100;
            decimal? futureValue = 0;

            for (int i = 0; i < months; i++) 
            {
                futureValue = (futureValue + monthlyInterstRate) * (1 + monthlyInterstRate);
            }
            return futureValue;
        }
    }
}
