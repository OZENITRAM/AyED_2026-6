using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            do
            {
                Console.Write("Ingrese su calificacion: ");
                nota = int.Parse(Console.ReadLine());
                if (nota < 1 || nota > 10)
                {

                    Console.WriteLine("Error, nota no valida, vuelva a ingresarla: ");




                }

            }

            while (nota < 1 || nota > 10);

            Console.WriteLine("Tu nota es: " + nota);
        }
    }
}


      

          