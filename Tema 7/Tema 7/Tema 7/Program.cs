using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7
{
    /// <summary>
    /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, max = int.MinValue, min = int.MaxValue;

            Console.WriteLine("Scrie secventa de numere dorita: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine($"Valoarea minima din secventa este: {min} iar valoarea maxima este: { max}");
            Console.ReadLine();
        }
    }
}
