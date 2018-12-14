using System;

namespace Calculator.Domain
{
    public class HandCalculator : IHandCalculator
    {
        public HandCalculator()
        {
            
        }
        
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }

        public string Mode { get; set; }
        
        public event EventHandler PoweringUp;
    }
}