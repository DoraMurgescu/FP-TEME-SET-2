using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_1
{
    /// <summary>
    /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, contorPare = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0 && n % 2 == 0)
                {
                    contorPare++;
                }
            }
            Console.WriteLine($"Numerele pare sunt: {contorPare}");
            Console.ReadLine();
        }
    }
}
