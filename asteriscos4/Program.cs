using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asteriscos4
{
    //crear el programa asteriscos4 en el que se introduce un numero entero y se crea una piramide de asteeriscos 
    class Program
    {
        static void Main(string[] args)
                    {
            int fila;
            bool bandera = false;
            do
            {
                Console.WriteLine("Ingresar Numero Impar por favor para nivel de Piramide: ");
                fila = Convert.ToInt32(Console.ReadLine());
                if (fila > 0 && fila % 2 != 0)
                {
                    bandera = true;
                }
            } while (!bandera);

            Console.Write("");

            int posicion = fila / 2 + 1;

            for (int i = 1; i <= posicion; i++)
            {
                for (int j = 1; j <= posicion - i; j++)
                {
                    Console.Write(" ");
                }
                for (int h = 1; h <= (2 * i) - 1; h++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
