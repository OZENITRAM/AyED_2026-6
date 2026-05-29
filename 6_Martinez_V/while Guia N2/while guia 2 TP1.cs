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

            int opcion = 0;
            int saldo = 10000;
            int plata = 0;

            while (opcion != 4)
            {
                Console.WriteLine("1. Depositar dinero: ");
                Console.WriteLine("2. Retirar dinero: ");
                Console.WriteLine("3. Ver saldo actual: ");
                Console.WriteLine("4. Salir: ");

                Console.Write("elegi una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        Console.Write("ingrese la plata que va a depositar: ");
                        plata = int.Parse(Console.ReadLine());
                        saldo = saldo + plata;
                        break;

                    case 2:
                        Console.Write("ingrese la plata que va a retirar: ");
                        plata = int.Parse(Console.ReadLine());
                        saldo = saldo - plata;
                        break;

                    case 3:

                        Console.WriteLine("su saldo actual es de " + saldo);
                        break;


                    case 4:
                        Console.WriteLine("saliendo xd ");
                        break;



                    default:


                        Console.WriteLine("opcion incorrecta, elija otra vez: ");
                        break;

                }

            }
        }
    }
}
