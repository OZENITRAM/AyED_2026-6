using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int contador = 0;
            int acumulador = 0;

            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Ingresa la temperatura del día: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;

                if (numero < 0)
                {
                    contador++;
                }
            }

           

            Console.WriteLine("La suma de las temperaturas es: " + acumulador);
           
            Console.WriteLine("Hay " + contador + " temperaturas menores a 0°C");







        }
    }
}
