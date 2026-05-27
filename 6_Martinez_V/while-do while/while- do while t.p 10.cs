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

            int A;
            int B;
            int resultado = 0;
            int contador = 1;

            Console.Write("ingresa el primer numero: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            B = int.Parse(Console.ReadLine());

            while (contador <= B)
            {
                resultado = resultado + A;
                contador++;
            }

            Console.WriteLine("resultado: " + resultado);
        }
    }

}
   
