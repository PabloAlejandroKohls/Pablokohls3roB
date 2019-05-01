using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor
{
    class Program
    {
        //programa que lea una serie de numeros por teclado e indique cual es el mayor
        static void Main(string[] args)
        {
            int Mayorserie = 0;
            Console.WriteLine("Ingrese la cantidad de numeros de la serie: ");
            int serie = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < serie; i++)
            {
                Console.WriteLine("Ingrese un la cantidad de numeros de la serie: " + i);
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > Mayorserie)
                {
                    Mayorserie = numero;
                }
            }
            Console.WriteLine("El numero mayor en esta serie es: " + Mayorserie);
            Console.ReadLine();
            {
            }
        }
    }
}
