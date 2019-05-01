using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificaciondeasteriscos4
{
    //Modificar el ejercicio anterior para poder hacer un rombo
    class Program
    {
        static void Main(string[] args)
        {
            int fila;
            bool bandera = false;
            int posicion;
            do
            {
                Console.WriteLine("Ingresar Numero Impar, de lo contrario le volveremos a preguntar: ");
                fila = Convert.ToInt32(Console.ReadLine());
                if (fila > 0 && fila % 2 != 0)
                {
                    bandera = true;
                }
            } while (!bandera);

            Console.Write("");

             posicion = fila / 2 + 1;

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

            posicion--;

            for (int i = 1; i <= posicion; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int h = 1; h <= (posicion - i) * 2 + 1; h++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
