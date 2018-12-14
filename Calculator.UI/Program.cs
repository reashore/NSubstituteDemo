using System;
using Calculator.Domain;

namespace Calculator.UI
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            HandCalculator handHandCalculator = new HandCalculator();

            int sum = handHandCalculator.Add(1, 2);
            int difference = handHandCalculator.Subtract(5, 4);
            int product = handHandCalculator.Multiply(5, 4);
            int quotient = handHandCalculator.Divide(10, 2);
            
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}