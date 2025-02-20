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
            Console.WriteLine("Insira a base do retângulo");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o altura do retângulo");
            double h = double.Parse(Console.ReadLine());


            double p = 2 * (b+h);
            double a = b*h;
            double d = Math.Sqrt(Math.Pow(b,2) + Math.Pow(h, 2));

            Console.WriteLine("A área do retângulo é " + a + " metros quadrados, o perímetro é " + p + " e a diagonal é " + d);
            Console.ReadLine();

        }
    }
}
