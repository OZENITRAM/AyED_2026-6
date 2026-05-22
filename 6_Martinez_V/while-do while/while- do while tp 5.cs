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

            string claveconrrecta = "xd";
            string clave = " ";

            while (clave != claveconrrecta)
            {
                Console.Write("ingrese una clave: ");

                clave = Console.ReadLine();
            } 

            Console.WriteLine(" acceso permitido ");
        }
    }
}
