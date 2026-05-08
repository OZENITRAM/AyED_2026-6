using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elegi una letra de esta lista: ");
            Console.WriteLine(" A ");
            Console.WriteLine(" B");
            Console.WriteLine(" C ");
            Console.WriteLine(" D ");
            Console.WriteLine(" F ");
            Console.Write("Tu letra elegida es: ");
           

            String letra;
            letra = Console.ReadLine();

            switch (letra)
               
            {
                case "A":
                    Console.WriteLine("Tu nota es un EXCELENTE");
                    break;

                case "B":
                    Console.WriteLine("Tu nota es un BUENO");
                    break;

                case "C":
                    Console.WriteLine("Tu nota es un Regular");
                    break;

                case "D":
                    Console.WriteLine("Tu nota es SUFICIENTE");
                    break;

                case "F":
                    Console.WriteLine("Tu nota es un REPROBADO");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
                    








                    }























            }
        }
    }

