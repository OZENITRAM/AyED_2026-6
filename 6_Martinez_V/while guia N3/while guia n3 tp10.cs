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

            int creditos = 100;
            int apuesta;
            int dado1;
            int dado2;
            int suma;

            do
            {
                Console.WriteLine("creditos: " + creditos);

                Console.Write("ingrese su apuesta (0 para retirarte): ");
                apuesta = int.Parse(Console.ReadLine());

                if (apuesta > 0 && apuesta <= creditos)
                {
                    Console.Write("ingrese el resultado del dado 1: ");
                    dado1 = int.Parse(Console.ReadLine());

                    Console.Write("ingrese el resultado del dado 2: ");
                    dado2 = int.Parse(Console.ReadLine());

                    suma = dado1 + dado2;

                    if (suma == 7 || suma == 11)
                    {


                        creditos = creditos + apuesta;

                        Console.WriteLine("ganasteeeeeeeeeeeeee");
                    }
                    else
                    {

                        creditos = creditos - apuesta;

                        Console.WriteLine("perdiste xd");



                    }
                }



            } while (creditos > 0 && apuesta != 0);

            Console.WriteLine("saldo final: " + creditos);
        }
    }

}