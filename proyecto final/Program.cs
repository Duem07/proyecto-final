using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Duilio Ortega
05/11/2022
Programa que muestra si un año es bisiesto o no
*/
namespace proyecto_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Ingrese un año: ");
            año = int.Parse(Console.ReadLine()); //Le pide al usuario que ingrese el año
            {
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine("El año {0} si es bisiesto", año);
                } //Es una condicion para que diga que el año debe ser divisor entre 4, entre 100 y entre 400

                else
                {
                    Console.WriteLine("El año {0} no es bisiesto ", año);
                } //dice que si no es ninguna de las demas que muestre que no es bisiesto 

                Console.ReadKey();

            }
        }
    }
}
