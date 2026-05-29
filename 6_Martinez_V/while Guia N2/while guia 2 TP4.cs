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
            string USUARIO = "olivere";
            string contraseñagod = "6717";

            string usuario;
            string contraseña;

            int intentos = 0;

            while (intentos < 3)
            {
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                contraseña = Console.ReadLine();

                if (usuario == USUARIO && contraseña == contraseñagod)
                {
                    Console.WriteLine("Bienvenido al sistema");
                    break;
                }

                intentos++;

                if(usuario != USUARIO || contraseña != contraseñagod)
                    {
                    Console.WriteLine("error, vuelva a intentarlo," + " hiciste " + intentos + " intento/s de 3");

                }
            }

            if (intentos == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
        }
    }


        }


