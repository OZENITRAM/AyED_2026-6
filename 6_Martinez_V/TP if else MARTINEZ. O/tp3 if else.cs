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

            Console.Write("¿Cuantos años luz hay que viajar:  ");

            int años_luz = Convert.ToInt32(Console.ReadLine());


            Console.Write("¿Cuantos litros de gasolina hay en el tanque:  ");


            int litros = Convert.ToInt32(Console.ReadLine());
            int xd = litros / años_luz;
            int alan = 12 - litros;
            if (xd >= 12)

            {

                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");

            }


            else
            {



                Console.WriteLine("Peligro: Combustible insuficiente, Faltan " + alan + " litros");

            }


        }
    }
}
