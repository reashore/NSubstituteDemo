using System;

namespace Calculator.Domain
{
    public interface IHandCalculator
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
        int Divide(int x, int y);
        string Mode { get; set; }
        // ReSharper disable once EventNeverInvoked.Global
        event EventHandler PoweringUp;
    }
}