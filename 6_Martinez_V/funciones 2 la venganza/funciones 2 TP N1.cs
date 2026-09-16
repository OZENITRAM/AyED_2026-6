using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System;

    using System;

    class Program
    {
        static int Mayor(int numero, int mayor)
        {
            if (numero > mayor)
                mayor = numero;

            return mayor;



    }

        static int Menor(int numero, int menor)
        {
            if (numero < menor)
                menor = numero;

            return menor;
           }


        static int Sumar(int numero, int suma)
        {
            return suma + numero;
        }

        static int ContarPares(int numero, int pares)
               {
            if (numero % 2 == 0)
                pares++;

            return pares;
                } 

        static int ContarImpares(int numero, int impares)
        {
            if (numero % 2 != 0)
                impares++;

            return impares;
        }

        static void Main()
        {
            Console.Write("¿cuantos nums va a ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());


            int mayor = 0;

            int menor = 0;


            int suma = 0;

            int pares = 0;

            int impares = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese un num: ");
                int numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = numero;
                    menor = numero;
                }

                mayor = Mayor(numero, mayor);
                menor = Menor(numero, menor);
                suma = Sumar(numero, suma);
                pares = ContarPares(numero, pares);
                impares = ContarImpares(numero, impares);
            }

            double promedio = (double)suma / cantidad;

            Console.WriteLine("num mayor: " + mayor);


            Console.WriteLine("num menor: " + menor);

            Console.WriteLine("promedio: " + promedio);
            Console.WriteLine("cantidadd e pares: " + pares);
            Console.WriteLine("cantidad de impares: " + impares);
        }
    }
}