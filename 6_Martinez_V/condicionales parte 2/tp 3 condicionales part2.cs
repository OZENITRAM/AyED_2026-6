using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu género (M o F): ");
            string genero = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (genero == "F" && edad >= 60 || genero == "M" && edad >= 65)
            {
                Console.WriteLine("Puede iniciar el trámite jubilatorio.");
            }
            else
            {
                Console.WriteLine("No puede iniciar el trámite jubilatorio.");
            }
        }
    }
}
