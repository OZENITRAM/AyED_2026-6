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




            Console.Write("Ingresa tu saldo actual: ");
            double saldo = Convert.ToDouble(Console.ReadLine());


            Console.Write("¿Cuanto dinero deseas retirar? ");
            double retiro = Convert.ToDouble(Console.ReadLine());


            if (retiro > saldo)
            {
                Console.WriteLine("fondos insuficientes");
            }

            else if (retiro % 1000 == 0)
            {
                Console.WriteLine("operacion realizada con exito. retiraste: " + retiro);
            }
            else
            {
                Console.WriteLine("solo aceptamos billetes de mil");




            }
        }
    }
}