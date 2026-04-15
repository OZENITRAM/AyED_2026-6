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


            {
                Console.Write("Ingresa un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 5 == 0)
                {
                    Console.WriteLine("El número si es múltiplo de 5");
                }
                else
                {
                    Console.WriteLine("El numero no es multiplo de 5");
                }
            }
        }
    }
}