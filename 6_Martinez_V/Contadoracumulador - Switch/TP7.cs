using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ponga un idioma de esta lista: ");
            Console.WriteLine("1: Ingles");
            Console.WriteLine("2: Frances");
            Console.WriteLine("3: Aleman");
                
            Console.Write("EliGE UN IDIOMA : ");

            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Hello");
                    break;

                case "2":
                    Console.WriteLine("Salut");
                    break;

                case "3":
                    Console.WriteLine("Hallo");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }




        }
    }
}
