using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero; 
            int total = 0;
            Console.Write("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero > 0)

            {
                total = total + numero;
                Console.Write("ingrese otro numero: ");
                
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma total es de: " + total);
        }
    }

}