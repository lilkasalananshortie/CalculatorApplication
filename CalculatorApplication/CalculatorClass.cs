using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApplication
{

    internal class CalculatorClass
    {

        public delegate X Formula<X>(X arg1, X arg2);
        public Formula<double> info;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
        public Formula<double> _info;
        public event EventHandler CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                CalculateEvent += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                CalculateEvent -= value;
            }
        }
    }
}