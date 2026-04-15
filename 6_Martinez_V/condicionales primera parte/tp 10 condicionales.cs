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
            {
                Console.Write("Ingresa el presupuesto disponible: ");
                int presupuesto = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa el costo de los materiales: ");
                int costo = Convert.ToInt32(Console.ReadLine());

                if (costo > presupuesto)
                {
                    int preciof = costo - presupuesto; 
                    Console.WriteLine("No alcanza el presupuesto Faltan "  + preciof + " pesos para completar la compra");
                }
                else
                {
                    int precioS = presupuesto - costo;
                    Console.WriteLine("El presupuesto alcanza, sobra " + precioS + " pesos");
                }
            }
        }
    }
}