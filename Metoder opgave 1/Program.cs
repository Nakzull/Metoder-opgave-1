using System;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            double numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            double numberTwo = Convert.ToInt32(Console.ReadLine());
            double addedNumbers = AddNumbers(numberOne, numberTwo);
            double dividedNumbers = DividedNumbers(numberOne, numberTwo);
            double dividedTotal = DivideTotalTimes(numberOne, numberTwo);
            double power = NumbersPower(numberOne, numberTwo);
            Console.WriteLine(dividedTotal);
        }

        public static double AddNumbers(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static double DividedNumbers(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }

        public static double DivideTotalTimes(double numberOne, double numberTwo)
        {
            double divided = numberOne / numberTwo;
            return Math.Floor(divided);
        }
        public static double NumbersPower(double numberOne, double numberTwo)
        {
            return Math.Pow(numberOne, numberTwo);
        }
    }
}
