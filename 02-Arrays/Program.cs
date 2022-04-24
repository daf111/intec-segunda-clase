using System;

namespace _02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 10, 8, 11, 3, 5 };

            int sumatoria = 0;
            for (int indice = 0; indice < numeros.Length; indice++)
            {
                sumatoria += numeros[indice];
            }

            Console.Write("El total es: " + sumatoria);
        }
    }
}
