using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota;
            int contador = 1;

            int suma = 0;
            int promedio;


            while (contador <= 5)
            {
                Console.Write("ingrese una nota: ");
                nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
                contador++;
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio es de: " + promedio);






        }
    }
}
