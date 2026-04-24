using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingresa una cantidad de segundos: ");

            int segundos = Convert.ToInt32(Console.ReadLine());

            if (segundos > 60)
            {
                int resultado = segundos / 60;


                Console.WriteLine("tus segundos a minutos son: " + resultado + " min. ");
            }
            else
            {
                Console.WriteLine("tus segundos son: " + segundos);










            }
        }
    }
}