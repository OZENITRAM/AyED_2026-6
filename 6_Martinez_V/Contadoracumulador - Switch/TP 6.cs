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



            Console.WriteLine("Menu");
            Console.WriteLine("(S)andwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa");

            Console.Write("Elige una opcion: ");

            string opcion;
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "S":
                    Console.WriteLine("SU producto es un Sandwich, el precio es %6900 ");
                    break;

                case "P":
                    Console.WriteLine("SU producto es una Pizza, el precio es $13700");
                    break;

                case "H":
                    Console.WriteLine("SU producto es una Hamburguesa, el precio es % 6700");
                    break;

                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }





        }
    }
}
