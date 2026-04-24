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


            Console.Write("Ingresa tu promedio: ");
            float promedio = Convert.ToSingle(Console.ReadLine());


            Console.Write("Ingresa la distancia de tu casa a la facultad en kilometros: ");
            float distancia = Convert.ToSingle(Console.ReadLine());


            if (promedio > 8 || distancia > 50)
            {
                Console.WriteLine("Beca concedida.");
            }
            else
            {
                Console.WriteLine("Beca no concedida.");
            }
        }
    }
}
