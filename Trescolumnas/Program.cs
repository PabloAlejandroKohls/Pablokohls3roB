using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trescolumnas
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un programa que lea un numero entero y positivoy que esescriba tres columnas
            int numeros0=0, numeros1 = 0, numeros2 = 0;
            Console.WriteLine("Ingrese la cantidad de numeros de la serie: ");
            int entero = Convert.ToInt16(Console.ReadLine());
            for ( numeros0 = 0; numeros0 <= entero; numeros0++)
            {
                numeros1 = ((numeros0 + 2) + numeros0);
                numeros2 = ((numeros0 + 3) + numeros0 + numeros0);
                Console.WriteLine((numeros0) + "  " + "  " + "  " + (numeros1) + "  " + "  " + "  " + (numeros2));
            }
            Console.ReadKey();
        }
    }
}
