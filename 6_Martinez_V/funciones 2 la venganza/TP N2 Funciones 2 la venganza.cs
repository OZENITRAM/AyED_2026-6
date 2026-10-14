using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    using System;

    class Program
    {
        static int SumarDivisores(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }

            return suma;
        }

        static void Main()
        {
            Console.Write("ingrese un num perfecto: ");
            int numero = int.Parse(Console.ReadLine());

            int suma = SumarDivisores(numero);

            if (suma == numero)
                Console.WriteLine("el num es..... pefelcto pefelto pefelto caballero *suena musica de cell perfecto*");
            else
                Console.WriteLine("el num no es perfecto");
        }
    }
}