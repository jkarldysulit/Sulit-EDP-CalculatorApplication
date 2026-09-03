using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        private Formula<double>? calculateHandler;

        public event Formula<double> CalculateEvent
        {
            add
            {
                calculateHandler += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculateHandler -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double Calculate(double arg1, double arg2)
        {
            return calculateHandler?.Invoke(arg1, arg2) ?? 0.0; //if null return 0.0
        }

        public double GetSum(double arg1, double arg2) => arg1 + arg2;//add
        public double GetDifference(double arg1, double arg2) => arg1 - arg2;//subtract
        public double GetProduct(double arg1, double arg2) => arg1 * arg2;//multiply
        public double GetQuotient(double arg1, double arg2) => arg1 / arg2;//divide
    }
}