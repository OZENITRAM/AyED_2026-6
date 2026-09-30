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
        static void MostrarNumeros(int Num1, int Num2)
        {
            for (int i = Num1; i <= Num2; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int ContarPares(int Num1, int Num2)
        {
            int pares = 0;

            for (int i = Num1; i <= Num2; i++)
            {
                if (i % 2 == 0)
                    pares++;
            }

            return pares;
        }

        static int ContarImpares(int Num1, int Num2)
        {
            int impares = 0;

            for (int i = Num1; i <= Num2; i++)
            {
                if (i % 2 != 0)
                    impares++;
            }

            return impares;
        }

        static int sumarNums(int Num1 , int Num2)
        {
            int suma = 0;

            for (int i = Num1; i <= Num2; i++)
            {
                suma = suma + i;
            }

            return suma;
        }

        static void Main()
        {
            Console.Write("ingresa el primer num: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el seg num: ");
            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("num:");
            MostrarNumeros(Num1, Num2);

            Console.WriteLine("nums pares: " + ContarPares(Num1, Num2));
            Console.WriteLine("nums impares " + ContarImpares(Num1, Num2));
            Console.WriteLine("la suma d tdo es: " + sumarNums(Num1, Num2));
        }
    }
}
