using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
            static void Main()
            {                double[] temperaturas = new double[7];
                double mayor, menor, suma = 0, promedio;

               


                for (int i = 0; i < 7; i++)
                {

                Console.Write("ingrese la temperatura del dia " + (i + 1) + ": ");
                    temperaturas[i] = double.Parse(Console.ReadLine());

                    suma += temperaturas[i];
                }

                
                mayor = temperaturas[0];

            menor = temperaturas[0];

                
                for (int i = 1; i < 7; i++)
                {

                    if (temperaturas[i] > mayor)
                    {

                    mayor = temperaturas[i];
                    }


                    if (temperaturas[i] < menor)
                    {
                        menor = temperaturas[i];
                    }
                }


                
                promedio = suma / 7;

               
                Console.WriteLine("La temperatura mas alta fue: " + mayor + "°C");
                Console.WriteLine("La temperatura mas baja fue: " + menor + "°C");
                Console.WriteLine("el promedio semanal es de: " + promedio +  "°C");
            }







        }








    }
    

