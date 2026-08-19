using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
       
        
            static void Main()
            {
                int[] asistencia = new int[20];
                int inasistencias = 0;

                
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("clase " + (i + 1) + " (1 = prsente, 0 = ausente): ");

                asistencia[i] = int.Parse(Console.ReadLine());

                    if (asistencia[i] == 0)
                    {
                        inasistencias++;
                    }
                }

                
                Console.WriteLine("total de inasistencias: " + inasistencias);

                if (inasistencias > 6)
                {

            Console.WriteLine("libre por inasistencias");
                }
                else
               {


                Console.WriteLine("regular xdxddxd");
                }
            }






        }




    }
 
