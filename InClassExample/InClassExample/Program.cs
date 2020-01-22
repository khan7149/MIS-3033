
//Faraz Khan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExample
{
    class Program
    {
        /// <summary>
        /// Sums up two numbers and provides the result
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        

        static double Add(double val1, double val2)
        {
            double sum = val1 + val2;
            return sum;
        }

        static void Main(string[] args)
        {
            double result = Add(5,6);

            Console.WriteLine($"5 + 6 = {result.ToString("N2")}");
            Console.ReadLine();
        }

       

        
    }
    
}

    