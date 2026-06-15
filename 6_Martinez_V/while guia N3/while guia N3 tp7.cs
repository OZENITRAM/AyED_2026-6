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

            string nombre;

            string estado;
            string respuesta = "S";

            int presentes = 0;
                
                
            int ausentes = 0;
            int total;

            double porcentaje;

            while (respuesta == "S")
            {




                Console.Write("ingresar nombre del alumno: ");


                nombre = Console.ReadLine();

                Console.Write("Estado (P/A): ");
                estado = Console.ReadLine();

                if (estado == "P")
                {


                    presentes = presentes + 1;


                }
                else
                {
                    ausentes = ausentes + 1;


                }

                Console.Write("¿desea cargar otro alumno? (S/N): ");
                respuesta = Console.ReadLine();
            }

            total = presentes + ausentes;
            porcentaje = (presentes * 100) / total;

            Console.WriteLine("presentes: " + presentes);


            Console.WriteLine("ausentes: " + ausentes);
            Console.WriteLine("porcentaje de presentismo: " + porcentaje + "%");
        }
    }



}
    
