using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void primo(int numero)
        {
            int divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                Console.WriteLine("es primo");
            }
            else
            {
                Console.WriteLine("no esprimo");
            }
        }

        static void Main()
        {
            Console.Write("ingrese un num: ");

           int numero = int.Parse(Console.ReadLine());

            primo(numero);
        }
    }
}