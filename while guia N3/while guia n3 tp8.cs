using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            int suma = 0;
            int cantidad = 0;
            int mayores = 0;

            int menores = 0;


            double promedio;

            while (edad >= 0)
            {
                Console.Write("ingresa una edad: (-1 para terminar): ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 0)
                {
                    suma = suma + edad;
                    cantidad = cantidad + 1;

                    if (edad >= 18)
                    {
                        mayores = mayores + 1;
                    }
                    else
                    {
                        menores = menores + 1;

                    }

                }

            }

            promedio = (double)suma / cantidad;

            Console.WriteLine("promedio de edad: " + promedio);

            Console.WriteLine("mayores de edad: " + mayores);
            Console.WriteLine("menores de edad: " + menores);
        }
    }

}