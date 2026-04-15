using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa tu altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Tu IMC es: " + imc);

            if (imc > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Rango normal");
            }



        }
    }
}
