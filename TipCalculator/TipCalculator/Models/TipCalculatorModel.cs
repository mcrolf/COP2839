namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        public double MealCost { get; set; }
        public double FifteenPercentTip { get; set; }
        public double TwentyPercentTip { get; set; }
        public double TwentyFivePercentTip { get; set; }

        public double CalcFifteenTip()
        {
            FifteenPercentTip = MealCost * 0.15;
            return FifteenPercentTip;
        }

        public double CalcTwentyTip()
        {
            TwentyPercentTip = MealCost * 0.2;
            return TwentyPercentTip;
        }

        public double CalcTwentyFiveTip()
        {
            TwentyFivePercentTip = MealCost * 0.25;
            return TwentyFivePercentTip;
        }
    }
}
