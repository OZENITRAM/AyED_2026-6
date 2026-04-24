using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresa tu sueldo actual: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());


            Console.Write("Ingresa tus años de antigüedad: ");
            int antigüedad = Convert.ToInt32(Console.ReadLine());


            double aumento;
            if (antigüedad > 10)
            {
                aumento = sueldo * 0.20;
            }
            else
            {
                aumento = sueldo * 0.05;
            }


            double sueldoNuevo = sueldo + aumento;


            Console.WriteLine("Tu sueldo nuevo es: " + sueldoNuevo);
        }




    }
    }
