using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Consumption_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, avgDistance;
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            avgDistance = (X/Y);
            Console.WriteLine($"{(avgDistance):F3} km/l");
            Console.ReadKey();
        }
    }
}
