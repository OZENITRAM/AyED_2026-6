using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;


            int contador = 2;

            Console.Write("ingresa un numero: ");


            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                Console.WriteLine(contador);

                contador = contador + 2;



            }
        }
    }




    }

