using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_11
{
    /// <summary>
    /// Se da o secventa de n numere. Se cere sa se calculeze suma inverselor acestor numere. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, s = 0, invers = 0;
            Console.Write("Introdu un numar: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                invers = 0;
                m = n % 10;
                n = n / 10;
                s = s + m;
                invers = invers * 10 + n;
            }
            Console.WriteLine($"Suma este: " + s);
            Console.ReadLine();
        }
    }
}
