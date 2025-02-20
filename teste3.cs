using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a temperatura em graus Fahrenheit que deseja converter para graus Celsius");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = ((5 * (fahrenheit - 32)) / 9);

            Console.WriteLine("A temperatura em graus celsius convertida de fahrenheit é" + celsius);

            Console.ReadLine();
        }
    }
}
