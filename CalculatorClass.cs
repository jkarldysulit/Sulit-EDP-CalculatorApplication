using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        private Formula<double>? _calculateHandler;

        public event Formula<double> CalculateEvent
        {
            add
            {
                _calculateHandler += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                _calculateHandler -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double Calculate(double arg1, double arg2)
        {
            return _calculateHandler?.Invoke(arg1, arg2) ?? 0.0;
        }

        public double GetSum(double arg1, double arg2) => arg1 + arg2;
        public double GetDifference(double arg1, double arg2) => arg1 - arg2;
        public double GetProduct(double arg1, double arg2) => arg1 * arg2;
        public double GetQuotient(double arg1, double arg2) => arg1 / arg2;
    }
}