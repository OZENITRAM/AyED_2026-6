using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
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

        static bool EsPerfecto(int numero)
        {
            int suma = SumarDivisores(numero);

            if (suma == numero)
                return true;
            else
                return false;
        }

        static void Main()
        {
            Console.Write("ingresa un num entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPerfecto(numero))
                Console.WriteLine("el num es..... perfecto *suena musica de cell perfecto*.");
            else
                Console.WriteLine("El número no es perfecto.");
        }
    }
}