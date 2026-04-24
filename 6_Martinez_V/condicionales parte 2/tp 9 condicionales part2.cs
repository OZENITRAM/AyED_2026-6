using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        { 
               Console.Write("¿cuantas horas dejaste el auto?: ");
                int horas = Convert.ToInt32(Console.ReadLine());

                Console.Write("¿con cuanta plata abonas?: ");
                int plata = Convert.ToInt32(Console.ReadLine());


                int precioH = 4000;
                if (horas > 1)
                {
                    precioH += (horas - 1) * 1600;
                }



            if (plata >= precioH)
            {
                int vuelto = plata - precioH;
                    Console.WriteLine("pago aceptado, el vuelto es: " + vuelto);
                }
                else
                {
                    int plataF = precioH - plata;
                    Console.WriteLine("plata insuficiente, falta: " + plataF);
                }
            }
    }
}
