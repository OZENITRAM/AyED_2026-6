using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static int Factorial(int numero)
        {
            int valor = 1;
            for (int i = 1; i <= numero; i++)
            {
                valor = valor * i;
                
            }
            return valor;
        }





        static void Main(string[] args)
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = Factorial(numero);
            Console.WriteLine(resultado);
        }




    }
}