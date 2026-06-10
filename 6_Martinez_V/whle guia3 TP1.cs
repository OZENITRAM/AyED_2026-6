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




            int precio = 1;
            int subtotal = 0;
            double descuento = 0;
            double total;

            while (precio != 0)

            {
                Console.Write("ingresa el precio del producto (0 para terminar): ");


                precio = int.Parse(Console.ReadLine());

                subtotal = subtotal + precio;
            }

            if (subtotal > 15000)


            {


                descuento = subtotal * 0.10;
            }

            total = subtotal - descuento;

            Console.WriteLine("subtotal: " + subtotal);


            Console.WriteLine("descuento: " + descuento);
            Console.WriteLine("total a pagar: " + total);
        }
    }


}
    