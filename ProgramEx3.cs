using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3POOMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da diagonal do quadrado: ");

            Double valorDiagonal = Double.Parse(Console.ReadLine());



            Quadrado quadrado = new Quadrado(valorDiagonal);

            Double area = quadrado.CalcularArea();



            Console.WriteLine("A área do quadrado é: {0}", area);
        }
    }
}
