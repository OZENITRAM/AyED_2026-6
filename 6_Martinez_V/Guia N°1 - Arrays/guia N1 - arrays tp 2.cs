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



            {
                int[] notas = new int[10];
                int aprobados67 = 0;
                int desaprobados = 0;

               int suma = 0;
                double promedio;

                
                for (int i = 0; i < 10; i++)


                {
                    Console.Write("ingrese la nota " + (i + 1) + ": ");
                    notas[i] = int.Parse(Console.ReadLine());

                    suma += notas[i];

                  if (notas[i] >= 6)
                    {
                        aprobados67++;
                    }
                    else
                    {
                        desaprobados++;
                    }
                }

                               promedio = (double)suma / 10;

                
                Console.WriteLine("alumno aprobados: " + aprobados67);
                Console.WriteLine("alumnos desaprobados: " + desaprobados);
                Console.WriteLine("promedio general del curso es de: " + promedio);
            }
        }








    }







    }

