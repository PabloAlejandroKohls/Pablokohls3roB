using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablamultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear el programa tabla multiplicar que escriba la tabla de multiplicar del 1 al numero 15
            int numero = 0, multiplicacion = 0;

            Console.WriteLine("los resultados de la siguiente multiplicacion es : ");
            numero = int.Parse(Console.ReadLine());

            for (int numero1= 1; numero1 <= 15; numero1++)
            {
                multiplicacion = numero * numero1;
                Console.WriteLine(numero1 + "*" + numero + "=" + multiplicacion);
            }
            Console.ReadKey();
        }
    }
}
