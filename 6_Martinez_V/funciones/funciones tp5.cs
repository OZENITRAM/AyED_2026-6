using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static int potencia(int BaseNUm, int Exponente)
        {
            int resultado = 1;
            for (int i = 1; i <= Exponente; i++)
            {
              resultado = resultado * BaseNUm;

            }
            return resultado;
        }





        static void Main(string[] args)
        {
            Console.Write("ingresa la base: ");
            int baseNUm = int.Parse(Console.ReadLine());
         


            Console.Write("ingresa el exponente: ");
            int Exponente = int.Parse(Console.ReadLine());
           

            int resultado = potencia(baseNUm, Exponente);
            Console.WriteLine(" el resultado es:" + resultado);
        }




    }
}