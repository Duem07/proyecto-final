using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_prueba_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int año;
            Console.WriteLine("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());

        if(año % 4 == 0)
        {

            
            if (año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año {0} si es bisiesto", año);
            }

            else
            {
                Console.WriteLine("El año {0} no es bisiesto ", año);
            }
           }
            else
          {
            Console.WriteLine("El año {0} no es bisiesto ", año);
           }
                Console.ReadKey();
        }
       }
}
