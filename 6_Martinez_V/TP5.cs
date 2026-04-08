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



            Console.Write("¿Cuantos minutos estuvo en el estacionamiento? ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            int hora = minutos / 60;


            int min = minutos % 60;

            Console.WriteLine(hora + " hora/s " + " con " + min + " minutos ");

            int preciohora = hora * 6000;
            int preciomin = min * 150;
            int preciofinal = preciohora + preciomin;



            int iva = preciofinal * 21 / 100;

            Console.WriteLine( iva + " del iva " );

            int montofinal = iva + preciofinal;

            Console.WriteLine( montofinal + " es el precio a pagar" );

        }
    }
}
