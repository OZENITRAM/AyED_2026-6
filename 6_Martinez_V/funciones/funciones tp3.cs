using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int SumarHasta(int numero)
        {
            int suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma = suma + i;
                Console.WriteLine(i);
            }
            return suma;
        }





        static void Main(string[] args)
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = SumarHasta(numero);
            Console.WriteLine(resultado);
        }




    }
}