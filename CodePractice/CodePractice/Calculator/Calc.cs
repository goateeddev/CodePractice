
using System;
using CodePractice.Calculator.Interfaces;

namespace CodePractice.Calculator
{
    public class Calc : ICalc
    {
        private readonly IFormatter _formatter;

        public Calc(IFormatter formatter)
        {
            _formatter = formatter;
        }
        
        public int SquareANumber(int number)
        {
            return (number * number);
        }

        public int? SquareANumber(string number)
        {
            var n = _formatter.StringToInt(number);
            return (n * n);
        }

        public double CalculateTax(double baserate, double tax)
        {
            return Math.Round(baserate / (1 + (tax / 100)), 2);
        }
    }
}
