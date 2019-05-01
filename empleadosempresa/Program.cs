using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleadosempresa
{
    //crear un programa para calcular el salario semanal de dos empleados a los que se paga 15 dolares por hora si estas no superan las35
    class Program
    {
        static void Main(string[] args)
        {
            int horasempleado = 0, salariosemanal = 0, horasextras;
            Console.WriteLine("Introduce La cantidad de horas: ");
            horasempleado = Convert.ToInt32(Console.ReadLine());

            if (horasempleado <= 35)
            {
                salariosemanal = (horasempleado * 15);
            }
            else
            {
                     horasextras = (horasempleado - 35) * 22;

                salariosemanal = (horasextras + (35 * 15));
            }
            Console.WriteLine("El Salario semanal de esta persona es de:" + salariosemanal);


            Console.WriteLine("Desea Realizar otro calculo: 1=SI   0=NO ");
            int ban = Convert.ToInt32(Console.ReadLine());
            if (ban == 1)
            {
                Console.Write("Introduce La cantidad de horas: ");
                horasempleado = Convert.ToInt32(Console.ReadLine());
                if (horasempleado <= 35)
                {
                    salariosemanal = (horasempleado * 15);
                }
                else
                {
                    horasextras = (horasempleado - 35) * 22;

                    salariosemanal = (horasextras + (35 * 15));
                }
                Console.WriteLine("El Salario semanal de Pablo es de:" + salariosemanal);
            }
            else
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
