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

            int venta;
            int total = 0;

            int cantidad = 0;
            int mayor = 0;

            string respuesta = "S";

            while (respuesta == "S")
            {
                Console.Write("ingresa el monto de la venta: ");
                venta = int.Parse(Console.ReadLine());

                total = total + venta;

                cantidad = cantidad + 1;

                if (venta > mayor)
                {


                    mayor = venta;

                }

                Console.Write("¿desea seguir ingresando mas ventas? (S/N): ");
                respuesta = Console.ReadLine();



            }

            Console.WriteLine("Total recaudado: " + total);

            Console.WriteLine("Cantidad de ventas: " + cantidad);
            Console.WriteLine("La venta más alta fue: " + mayor);
        }


    }







}
   
