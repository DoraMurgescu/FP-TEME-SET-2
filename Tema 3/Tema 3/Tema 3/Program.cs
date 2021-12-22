using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3
{
    /// <summary>
    /// Calculati suma si produsul numerelor de la 1 la n. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, S = 0, P = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                    S = S + i;
                    P = P + i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {S}");
            Console.WriteLine($"produsul numerelor de la 1 la {n} este:{P}");
            Console.ReadLine();
        }

    }
}
