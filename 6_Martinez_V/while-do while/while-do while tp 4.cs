using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            int contador = 1;

            Console.Write("Ingresá un número: ");
            num = int.Parse(Console.ReadLine());

            while (contador <= 12)
            {
                Console.WriteLine(num + " x " + contador + " = " + (num * contador));
                contador = contador + 1;
            }
        }
    }
}
