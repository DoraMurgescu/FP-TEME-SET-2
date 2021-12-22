using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4
{/// <summary>
/// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
/// Se considera ca primul element din secventa este pe pozitia zero. 
/// Daca numarul nu se afla in secventa raspunsul va fi -1. 
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n, contor = 0, a, a1, poz = 0;

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
                    poz = 1;
                }
                contor++;
            }
            if (poz == 1)
            {
                Console.WriteLine($"Lucky guess! Numarul {a} se afla pe pozitia {contor}");
            }
            else
            {
                Console.WriteLine("A bad day? :) Nu s-a gasit numarul a, in consecinta se afiseaza: -1");
            }
            Console.ReadLine();
        }
    }
}
