using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingre la cantidad de nivel de midiclorianos: ");

            int medicloriano = Convert.ToInt32(Console.ReadLine());


            if (medicloriano >= 15000)

            {

                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo");

            }


      else if( 5000 < medicloriano)

            {
         
                  

                Console.WriteLine(" Aceptable para entrenamiento Padawan");


            }

       else
            {
            
                Console.WriteLine("No posee sensibilidad a la Fuerza");
            }

           
        }
    }
}
