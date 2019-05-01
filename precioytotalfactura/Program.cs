using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precioytotalfactura
{
    //crear un programaque lea cantidades y precioy al final indique el total de la factura 
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            Double precio = 0, totalde_factura = 0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese la cantidad que se ha vendido: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    if (cantidad < 0)
                    {
                        Console.Write("Cantidad es incorrecta");
                    }
                } while (cantidad < 0);
                if (cantidad > 0)
                {
                    Console.WriteLine("Ingrese el precio: ");
                    do
                    {
                        precio = Convert.ToDouble(Console.ReadLine());
                        if (precio < 0)
                        {
                            Console.Write("Precio incorrecto");
                        }
                        else
                        {
                            totalde_factura += cantidad* precio;
                        }
                    } while (precio < 0);
                }
            } while (cantidad != 0);

            Console.Write("El Total de la venta es: " + totalde_factura);
            Console.ReadKey();
            {
            }
        }
    }
}
