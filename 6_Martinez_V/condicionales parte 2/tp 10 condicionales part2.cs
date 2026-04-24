using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("¿cuantas facturas se produjeron al inicio del dia?: ");
            int facturas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿cuantas docenas completas se vendieron?: ");
            int docenas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿cual es el precio por docena?: ");
            double precioPorDocena = Convert.ToDouble(Console.ReadLine());


            int facturasSo = facturas - (docenas * 12);


            double plata = docenas * precioPorDocena;


            Console.WriteLine("facturas sobrantes: " + facturasSo);
            Console.WriteLine("plata recaudada:" + plata);


            if (facturasSo > 6)
            {
           Console.WriteLine("Alerta: Exceso de produccion"  );
            }
            else
            {
            Console.WriteLine("Producción eficiente" );
            }

        }
    }
}
