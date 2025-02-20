using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho do lado do quadrado");
            double l = double.Parse(Console.ReadLine());

            double r2 = Math.Sqrt(2);
            double p = 4 * l;
            double a = Math.Pow(l, 2);
            double d = l * r2;

            Console.WriteLine("A área do quadrado é " + a + ", o perímetro é " + p + " e a diagonal é " + d);
            Console.ReadLine();

        }
    }
}
