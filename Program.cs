using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareSum = Math.Pow(5050, 2);
            double sumOfSquares = 0 ;
            double difference;
            int i = 1;

            double startTime = Environment.TickCount;
            for (i=1; i <= 100; i = i +1 )
            {
                sumOfSquares = sumOfSquares + Math.Pow(i, 2);
            }

            difference = sumOfSquares - squareSum;
            double endTime = Environment.TickCount;
            Console.WriteLine("the total difference is " + difference);
            Console.WriteLine("time to compute in ms: " + (endTime - startTime));
            Console.ReadKey();
        }
    }
}
