using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingresa el nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingresa la contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == "admin" )
            {
                if(contraseña == "1234")

                Console.WriteLine("Acceso concedido.");
                else
                    Console.WriteLine("Error de credenciales.");
            }
            else
            {
                Console.WriteLine("Error de credenciales.");
            }
        }
    }
}
