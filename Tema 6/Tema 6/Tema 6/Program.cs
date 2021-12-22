using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6
{
    /// <summary>
    /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c, count = 0;

            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                c = int.Parse(Console.ReadLine());

                if (a <= b && b <= c)
                {
                    count++;
                }
                a = b;
                b = c;
            }
            
            if (a <= b)
            {
                Console.WriteLine("Numerele sunt in ordine  crescatoare.");
            }
            else
            {
                Console.WriteLine("Numerele nu sunt in ordine crescatoare.");
            }
            Console.ReadLine();
        }
    }
}
