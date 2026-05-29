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
            int NumSecreto = 67;
            int numero = 0;
            int intentos = 0;

            while (intentos < 5)
            {
                Console.Write("adivina el numero: ");
                numero = int.Parse(Console.ReadLine());

                intentos++;

                if(numero == NumSecreto)
                {

                    Console.WriteLine("Lo logro señor");
                    Console.WriteLine("lo hiciste en " + intentos + " intentos");


                    intentos = intentos + 5;
                   

                }

                if(numero < NumSecreto)
                {

                    Console.WriteLine("número es mayor: ");

                }
                if(numero > NumSecreto)
                {


                    Console.WriteLine("el numero es menor: ");


                }
                if(intentos == 5 && numero !=5 )
                {

                    Console.WriteLine("perdiste");

                    Console.WriteLine("hiciste " + intentos + " intentos");


                }
            }







        }
    }
}
