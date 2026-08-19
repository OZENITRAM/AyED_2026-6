using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
      
            static void Main()
            {

            double[] precios = new double[8];
                double dinero;
                int cantidad = 0;

    
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("ingrese el precio del producto " + (i + 1) + ": ");


                precios[i] = double.Parse(Console.ReadLine());
                }




            Console.Write("ingrese el dinero disponible: ");
                dinero = double.Parse(Console.ReadLine());

                
        for (int i = 0; i < 8; i++)
                {
                    if (precios[i] <= dinero)
                    {
                   cantidad++;
                    }
                }



          
                Console.WriteLine("puede comprar " + cantidad + " productos distintos.");
            }
        }
    }
   
