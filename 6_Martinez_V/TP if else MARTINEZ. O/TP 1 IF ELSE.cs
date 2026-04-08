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
            Console.Write("¿Cuanto  pesa la maleducada?: ");

            int peso = Convert.ToInt32(Console.ReadLine());


            if (peso <= 5000)

            {

                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");

            }
             else
            {
                int diferenciaDEpeso = peso - 5000;
                Console.WriteLine(" Alerta: Exceso de peso. Debes descargar " + diferenciaDEpeso + " kg para despegar ");

            }





        }
    }
}
