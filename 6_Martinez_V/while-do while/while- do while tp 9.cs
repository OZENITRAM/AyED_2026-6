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

            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Despedirse");
                Console.WriteLine("3. Salir");

                Console.Write("Elegí una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Holandaa");
                }

                if (opcion == 2)
                {
                    Console.WriteLine("bye bye");
                }
            }

            Console.WriteLine("Programa finalizado");
        }
    }



}
    
   
