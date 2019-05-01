using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriscosPablo
{
    //crear unprograma que lea un numero entero y a partir de el cree un cuadrado
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el lado del cuadrado: ");
            int Ladodelcuadrado = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Ladodelcuadrado; i++)
            {
                for (int j = 1; j <= Ladodelcuadrado; j++)
                {
                    if (i == 1 || j == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if (i == Ladodelcuadrado || j == Ladodelcuadrado)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

            {
            }
        }
    }
}
