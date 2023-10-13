using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please Enter an Amount...")]
        [Range(0.5, 500, ErrorMessage = "Enter an amount between 0.5 and 500...")]
        public double? MealCost { get; set; }

        public double? FifteenPercentTip { get; set; }

        public double? TwentyPercentTip { get; set; }

        public double? TwentyFivePercentTip { get; set; }

        public double? CalcFifteenTip()
        {
            FifteenPercentTip = MealCost * 0.15;
            return FifteenPercentTip;
        }

        public double? CalcTwentyTip()
        {
            TwentyPercentTip = MealCost * 0.2;
            return TwentyPercentTip;
        }

        public double? CalcTwentyFiveTip()
        {
            TwentyFivePercentTip = MealCost * 0.25;
            return TwentyFivePercentTip;
        }
    }
}
