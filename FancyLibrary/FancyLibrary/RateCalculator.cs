namespace FancyLibrary
{
    public interface IRateCalculator
    {
        string FizBuz(int i);
    }

    public class RateCalculator : IRateCalculator
    {
        public string FizBuz(int i)
        {
            var divisibleByThree = DivisibleBy(i, 3);
            var divisibleByFive = DivisibleBy(i, 5);

            if (divisibleByThree && divisibleByFive) return "FizBuz";
            if (divisibleByThree) return "Fiz";
            return divisibleByFive ? "Buz" : i.ToString();
        }

        private static bool DivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}