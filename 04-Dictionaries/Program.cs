using System;
using System.Collections.Generic;

namespace _04_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("20-46324567-2", "Juan Carlos");
            dictionary.Add("27-46324567-7", "María Perez");

            dictionary["27-46324567-7"] = "xxxxxxxxxx";

            Console.WriteLine(dictionary["27-46324567-7"]);
        }
    }
}
