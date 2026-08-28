using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void ContarHasta(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }





        static void Main(string[] args)
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());

            ContarHasta(numero);

        }




    }
}
