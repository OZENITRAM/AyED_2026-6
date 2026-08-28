using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void ContarRegresivo(int numero)
        {
            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }





        static void Main(string[] args)
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());

            ContarRegresivo(numero);

        }




    }
}