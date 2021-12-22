using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    /// <summary>
    /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int positiveCounter = 0;
            int negativeCounter = 0;
            int equalCounter = 0;
            do
            {
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    positiveCounter++;
                }

                if (n < 0)
                {
                    negativeCounter++;
                }

                if (n == 0)
                {
                    equalCounter++;
                    positiveCounter++;  //Am pus positiveCounter pentru ca asa numara si dublurile.
                }
                
            } while (n != 0);

            Console.WriteLine($"Numerele pozitive sunt: {positiveCounter}, numerele negative sunt: {negativeCounter} iar numerele egale sunt: {equalCounter}");
            Console.ReadLine();
        }
    }
}
