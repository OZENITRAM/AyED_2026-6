using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            int gasto;
            int total = 0;
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa el gasto: ");
                gasto = int.Parse(Console.ReadLine());

                total += gasto;

                if (gasto > 500)
                {
                    contador++;
                }
            }

            Console.WriteLine("El gasto total sumado es: " + total);
            Console.WriteLine("Los gastos mayores a 500 son: " + contador);


        }
    }
}
