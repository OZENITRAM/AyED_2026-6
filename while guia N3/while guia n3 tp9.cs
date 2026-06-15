using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            int menor = 0;

            Console.Write("ingresa un numero positivo (numero negativo para terminar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {

                menor = numero;

                while (numero >= 0)
                {


                    if (numero < menor)
                    {
                        menor = numero;
                    }

                    Console.Write("ingresa otro número (numero negativo para terminar): ");
                    numero = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("el numero menor es: " + menor);
            }
        }
    }

}
    