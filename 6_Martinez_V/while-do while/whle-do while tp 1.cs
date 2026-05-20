using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Introduce un numero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("comineza la cuenta regresiva:");
            while (numero >= 0)

              {
                

                   Console.WriteLine(numero);
                numero = numero - 1;
              }

        }
    }
}
