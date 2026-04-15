using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingresa el primer lado: ");
            int ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo lado: ");
            int ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el tercer lado: ");
            int ladoC = Convert.ToInt32(Console.ReadLine());

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("El triangulo es Equilatero");
            }
            else
            {
                if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("El triangulo es Isosceles");
                }
                else
                {
                    Console.WriteLine("El triangulo es Escaleno");
                }
            }



        }
    }
}
