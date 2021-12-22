using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_8
{
    /// <summary>
    /// Determianti al n-lea numar din sirul lui Fibonacci. 
    /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
    /// <exemple>
    /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
    /// </exemple>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, f1 = 0, f2 = 1, f;

            Console.WriteLine("Introduceti numarul n dorit: ");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Primul termen este: 0");
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine("Al doilea termen este: 1");
                }
                Console.Write($"Primii {n} termeni sunt: ");
                Console.WriteLine($"{f1} si {f2} sunt primii doi termeni, urmatorii termeni sunt: ");

                for (int i = 3; i <= n; i++)
                {
                    f = f1 + f2;
                    Console.Write($"{f}");
                    f1 = f2;
                    f2 = f;
                }
            }
            Console.ReadLine();
        }
    }
}
