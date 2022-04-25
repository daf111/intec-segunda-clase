using System;
using System.Collections.Generic;
using System.IO;

namespace _06_Reader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza muchos cálculos...

            List<List<string>> clientes = new List<List<string>>();

            /*
             * Datos de prueba
             */
            List<string> unCliente;

            unCliente = new List<string>();
            unCliente.Add("Juan Carlos");
            unCliente.Add("10/1/2000");
            unCliente.Add("jcarlos@gmail.com");
            clientes.Add(unCliente);

            unCliente = new List<string>();
            unCliente.Add("Ana Perez");
            unCliente.Add("19/02/2000");
            unCliente.Add("aperez@gmail.com");
            clientes.Add(unCliente);

            unCliente = new List<string>();
            unCliente.Add("Julian Fernandez");
            unCliente.Add("21/04/2000");
            unCliente.Add("jfernandez@gmail.com");
            clientes.Add(unCliente);

            /**
             * Escribir un archivo de texto
             */
            string directorio = Environment.CurrentDirectory;
            StreamWriter writer = new StreamWriter(directorio + "\\clientes.txt");

            foreach (List<string> unClienteEnLista in clientes)
            {
                writer.WriteLine(GeneraStringDeClientesParaArchivoTXT(unClienteEnLista));
            }

            writer.Close();

            /**
             * Leer un archivo de texto
             */
            StreamReader reader = new StreamReader(directorio + "\\clientes.txt");

            string linea;
            string[] cliente = new string[3];
            while ((linea = reader.ReadLine()) != null)
            {
                cliente = linea.Split(",");
                Console.WriteLine(cliente[0] + " nació el " + cliente[1] + " y su email es " + cliente[2]);
            }

            reader.Close();
        }

        static string GeneraStringDeClientesParaArchivoTXT(List<string> unCliente)
        {
            return string.Join(",", unCliente);
        }
    }
}
