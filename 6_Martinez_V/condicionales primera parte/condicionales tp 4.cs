using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        { 
                Console.Write("Ingresa la nota del examen: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("Promocionado");
                }
                else if (nota >= 4)
                {
                    Console.WriteLine("A finales");
                }
                else
                {
                    Console.WriteLine("Recuperatorio");
                }
            }
        }




    }

