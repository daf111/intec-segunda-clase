using System;
using System.Collections.Generic;

namespace _05_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Hola");
            stack.Push("Chau");

            //..... hago cosas

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
