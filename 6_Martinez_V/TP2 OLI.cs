using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_Oliver_Martinez
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            string juego;
            string consola;

            Console.WriteLine("hola papu");
            Console.Write("¿Cual es tu nombre?: " );

            nombre = Console.ReadLine();

    

            Console.Write("¿Cual es tu juego favorita?: " );
            juego = Console.ReadLine();
            Console.Write("¿en que consola jugas?: ");
            consola = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " Tu juego favorito es " + juego + " y se juega en " + consola);








        }
    }
}
