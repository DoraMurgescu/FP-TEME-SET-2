using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5
{
    /// <summary>
    /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
    /// Se considera ca primul element din secventa este pe pozitia 0. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, contor = 0, a, a1;

            Console.WriteLine("Introduceti numarul n dorit: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul a dorit: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele dorite: ");

            for (int i = 0; i < n; i++)
            {
                a1 = int.Parse(Console.ReadLine());

                if (a1 == a)
                {
                    contor++;
                }
            }
            Console.WriteLine($"Yup, avem! Contor spune: {contor} elemente sunt egale cu pozitia pe care apar.");
            Console.ReadLine();
        }
    }
}
