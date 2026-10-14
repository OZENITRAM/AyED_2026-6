using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{ 
using System;

class Program
{
    static int ContarPositivos(int numero, int positivos)
    {
        if (numero > 0)
            positivos++;

        return positivos;
    }

    static int ContarNegativos(int numero, int negativos)
    {
        if (numero < 0)
            negativos++;

        return negativos;
    }

    static int ContarCeros(int numero, int ceros)
    {
        if (numero == 0)
            ceros++;

        return ceros;
    }

    static int SumarPositivos(int numero, int suma)
    {
        if (numero > 0)
            suma = suma + numero;

        return suma;
    }

    static int SumarNegativos(int numero, int suma)
    {
        if (numero < 0)
            suma = suma + numero;

        return suma;
    }

    static void Main()
    {
        Console.Write("cuantos nums va a ingresar?: ");
        int cantidad = int.Parse(Console.ReadLine());

        int positivos = 0;

        int negativos = 0;
        int ceros = 0;

        int sumaPositivos = 0;
        int sumaNegativos = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("ingrese un num: ");
            int numero = int.Parse(Console.ReadLine());


            positivos = ContarPositivos(numero, positivos);

            negativos = ContarNegativos(numero, negativos);
            ceros = ContarCeros(numero, ceros);

            sumaPositivos = SumarPositivos(numero, sumaPositivos);
            sumaNegativos = SumarNegativos(numero, sumaNegativos);
        }

        Console.WriteLine("cantidad d nums posi: " + positivos);
        Console.WriteLine("Cantidad d nums negativos: " + negativos);

        Console.WriteLine("cantidad de ceros: " + ceros);

        if (positivos > 0)
            Console.WriteLine("promedio de positivos: " + (double)sumaPositivos / positivos);

    else
            Console.WriteLine("ni se ingreso los nums positivos.");

        if (negativos > 0)
    Console.WriteLine("promedio de negativos : " + (double)sumaNegativos / negativos);


        else
            Console.WriteLine("no se ingreso los nums negativos");
    }
}
}