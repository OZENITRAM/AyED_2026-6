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
            Console.Write("¿Cuántos droides compras?: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int preciodecadauno = 2000;
            int total = cantidad * preciodecadauno;

            if (cantidad >= 3)
            {
                int descuento = total * 20 / 100;
                int precioFinal = total - descuento;

                Console.WriteLine("Total original: " + total);
                Console.WriteLine("Descuento: " + descuento);
                Console.WriteLine("Precio final: " + precioFinal);
            }
            else
            {
                Console.WriteLine("Total a pagar: " + total);
            }




        }
    }
}
