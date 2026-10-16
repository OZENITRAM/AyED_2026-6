using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    using System;

    class Program
    {
        static int ContarFactores(int numero)
        {
            int cantidad = 0;
            int divisor = 2;

            while (numero > 1)
            {
                if (numero % divisor == 0)
                {
                    cantidad++;
                    numero = numero / divisor;
                }
                else
                {
             divisor++;
                }
            }

            return cantidad;
        }

        static void MostrarFactores(int numero)


        {
            int divisor = 2;

            while (numero > 1)
            {
        if (numero % divisor == 0)
                {
                    Console.Write(divisor + " ")
                        ;
                    numero = numero / divisor;
                }
     else
                {



                    divisor++;
                }
            }
        }

        static void Main()
        {
            Console.Write("Iimgresa un num entero positivo mayor a 1: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 1)
            {
                Console.Write("factoeres primos: ");
                MostrarFactores(numero);

                Console.WriteLine();
                Console.WriteLine("total de factores primos " + ContarFactores(numero));

            } 
        }
    }
}