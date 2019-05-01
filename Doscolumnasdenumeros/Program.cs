using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doscolumnasdenumeros
{
    //crear un programa que escriba dos columnas de numeros
    class Program
    {
        static void Main(string[] args)
        {
            for (var numeros = 1; numeros <= 100; numeros++)
            {
                Console.WriteLine((numeros) + "    " + "  " + "  " + (101 - numeros) + " "); 
            }
            Console.ReadKey();
            
        }
    }
}
