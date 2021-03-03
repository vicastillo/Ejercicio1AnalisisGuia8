using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1AnalisisGuia8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Title = "Calcular edad";

            int edad, año;
            Console.WriteLine("Por favor ingrese su año de nacimiento:");
            año = int.Parse(Console.ReadLine());

            edad = DateTime.Today.Year - año;

            Console.WriteLine("Usted tiene " + edad + " años de edad.");

            Console.ReadKey();
        }
    }
}
