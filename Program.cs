using System;

namespace PercentCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var profit = Calculate(Console.ReadLine());
                Console.WriteLine(profit);
            }
        }

        public static double Calculate(string userInput)
        {
            var data = userInput.Split(" ");
            var deposit = Double.Parse(data[0]);
            var percent = Double.Parse(data[1]) / 100;
            var monthCount = Int32.Parse(data[2]);
            for(var i = 1; i <= monthCount; i++)
            {
                deposit += deposit * percent / 12;
            }
            return deposit;
        }
    }
}
