using System;
using System.Collections.Generic;

namespace _03_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(10);
            numeros.Add(8);
            numeros.Add(11);
            numeros.Add(3);
            numeros.Add(5);

            int sumatoria = 0;
            for (int indice = 0; indice < numeros.Count; indice++)
            {
                sumatoria += numeros[indice];
            }

            Console.Write("El total es: " + sumatoria);
        }
    }
}
