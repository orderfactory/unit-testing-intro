using System.Threading.Tasks;

namespace FancyLibrary
{
    public interface IRateCalculator
    {
        Task<string> FizBuz(int i);
    }

    public class RateCalculator : IRateCalculator
    {
        public async Task<string> FizBuz(int i)
        {
            var divisibleByThreeTask = DivisibleBy(i, 3);
            var divisibleByFiveTask = DivisibleBy(i, 5);

            var divisibleByThree = await divisibleByThreeTask;
            var divisibleByFive = await divisibleByFiveTask;

            if (divisibleByThree && divisibleByFive) return "FizBuz";
            if (divisibleByThree) return "Fiz";
            return divisibleByFive ? "Buz" : i.ToString();
        }

        private static async Task<bool> DivisibleBy(int number, int divisor)
        {
            await Task.Delay(5);
            return number % divisor == 0;
        }
    }
}