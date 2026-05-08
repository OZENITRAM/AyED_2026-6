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
            int numero;
            int divisor = 0;

            Console.Write("Ingresa un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("El numero no es primo.");
            }
            else 
            {
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisor = i;
                        break;
                    }
                }

                if (divisor == 0)
                {
                    Console.WriteLine("El numero es primo.");
                }
                else
                {
                    Console.WriteLine("El numero no es primo.");
                    Console.WriteLine("El primer divisor encontrado fue: " + divisor);
                }
            }
        }
    }
}
