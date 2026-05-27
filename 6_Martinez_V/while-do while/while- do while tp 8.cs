using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int temperatura;

            Console.Write("Ingresá la temperatura inicial: ");
            temperatura = int.Parse(Console.ReadLine());

            while (temperatura > 24)
            {
                temperatura = temperatura - 2;

                Console.WriteLine("Enfriando... Temperatura actual: " + temperatura + "°C");
            }

            Console.WriteLine("Temperatura ideal alcanzada");
        }
    }
    }
