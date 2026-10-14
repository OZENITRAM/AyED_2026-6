using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System;

    class Program
    {
        static int capicua(int numero)
        {
            int invertido = 0;

            while (numero > 0)
            {
                int digito = numero % 10;
                invertido = invertido * 10 + digito;
                numero = numero / 10;
            }

            return invertido;
        }

        static int ContarDigitos(int numero)
        {
            int cantidad = 0;

            if (numero == 0)
                return 1;

            while (numero > 0)
            {
                cantidad++;
                numero = numero / 10;
            }

            return cantidad;
        }

        static void Main()
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());

            int cantidad = ContarDigitos(numero);

            Console.WriteLine("cantidad de digitos: " + cantidad);

            if (numero == capicua(numero))
                Console.WriteLine("el num es capicua");
            else
                Console.WriteLine("el num no es capicua.");
        }
    }
}