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


            string dato = "";
            int numero;


            int positivos = 0;

            int negativos = 0;


            int ceros = 0;

            while (dato != "X" && dato != "N")
            {
                Console.Write("ingresa un numero (X o N para salir): ");
                dato = Console.ReadLine();

                if (dato != "X" && dato != "N")
                {
                    numero = int.Parse(dato);

                    if (numero > 0)
                    {
                        positivos = positivos + 1;



                    }
                    else if (numero < 0)
                    {
                        negativos = negativos + 1;
                    }
                    else
                    {
                        ceros = ceros + 1;
                    }
                }


            }

            Console.WriteLine("Positivos: " + positivos);

            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }



    }





}




