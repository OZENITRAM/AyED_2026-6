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


            Console.Write("dame un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("dame un segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());



            Console.Write("dame un tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("el mayor es: " + num1);
                }
                else
                {
                    Console.WriteLine("el mayor es: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("el mayor es: " + num3);
                }
            }

        }
    }
}
