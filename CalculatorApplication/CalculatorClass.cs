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

         double numb1, numb2;
        public  double GetSum(double sum) 
        {  
            return numb1 + numb2; 
        }

        public double GetDifference(double diff) 
        { 
            return numb1 - numb2; 
        }

        public double GetProduct(double product)
        {
            return numb1 * numb2;
        }
        public double GetQuotient(double ans)
        {
            return numb1 / numb2;
        }

        public Formula<double> _info;
        public event EventHandler CalculateEvent 
        { 
            add 
                { 
                    Console.WriteLine("Added the Delegate"); 
                    CalculateEvent += value;
                }
            remove { 
                Console.WriteLine("Removed the Delegate");
                CalculateEvent += value;
            }
        }        
        }
    }

