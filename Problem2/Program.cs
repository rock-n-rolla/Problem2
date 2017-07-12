using static System.Console;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(SumOfEvenValuedTerms(4_000_000));
        }

        static ulong SumOfEvenValuedTerms(uint hi)
        {
            uint previous2 = 1;
            uint previous1 = 1;
            uint currentEven = 2;

            uint sum = currentEven;

            while (true)
            {
                previous2 = previous1 + currentEven;
                previous1 = previous2 + currentEven;
                currentEven = previous1 + previous2;

                if (currentEven > hi)
                    return sum;

                sum += currentEven;
            }
        }
    }
}