using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10MENU
{
    //crear un prgrama que muestre un MEnU como este
    //1)SALIR
    //2)SUMATOTAL
    //3)FACTORIAL
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, factorial = 1, fac = 0;
            Console.Write("MENÚ DE OPCIONES");
            Console.WriteLine("  ");
            Console.Write("1) Salir");
            Console.WriteLine("  ");
            Console.Write("2) Sumatorio");
            Console.WriteLine("  ");
            Console.Write("3) Factorial");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese Opción: ");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.WriteLine("Ingrese cantidad a sumar: ");
                    int entero = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= entero; i++)
                    {
                        suma = suma + entero;
                    }
                    Console.WriteLine("La suma total es: " + suma);
                    break;
                case 3:
                    Console.WriteLine("ingrese la cantidad que quieres sacar factorial");
                    int fact = Convert.ToInt32(Console.ReadLine());
                    for (int i=fact ; i>0; i--)
                    {
                        factorial = factorial* i;
                    }
                    Console.WriteLine("El factorial de "+ fact +" es: "+ factorial);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
