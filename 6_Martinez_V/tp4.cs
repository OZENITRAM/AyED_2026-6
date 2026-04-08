using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingrese un numero: ");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese otro numero: ");


            int num2 = Convert.ToInt32(Console.ReadLine());

            int suma = (num1 + num2);


            int resta = (num1 - num2);


            int multiplicacion = (num1 * num2);


            int division = (num1 / num2);


            Console.WriteLine(" el resultado de la suma es: " + suma);

            Console.WriteLine(" el resultado de la resta es: " + resta);

            Console.WriteLine(" el resultado de la multi es: " + multiplicacion);

            Console.WriteLine(" el resultado de la division es: " + division);


        }
    }
}
