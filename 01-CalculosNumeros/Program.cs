using System;

namespace _01_CalculosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al programa que ejecuta divisiones");
            Console.WriteLine("Ingrese el divisor");

            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dividendo");
            int dividendo = int.Parse(Console.ReadLine());

            int division = divisor / dividendo;
            Console.WriteLine(division);
        }
    }
}
