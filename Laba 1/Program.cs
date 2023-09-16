using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите сторону a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите сторону b :");
            int b = Convert.ToInt32(Console.ReadLine());
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine($"S = {S}  P = {P}");

            Console.ReadKey ();


        }
    }
}
