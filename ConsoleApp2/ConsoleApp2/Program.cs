using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            while (true)
            {
                Console.Write("ingrese el nombre del cliente(para salir ingrese fin):");
                string nombre = Console.ReadLine();
                if (nombre != "fin")
                {
                    clientes.Enqueue(nombre);
                }
                else
                {
                    break;
                }
            }


            while (true)
            {
                if (clientes.Count == 0)
                {
                    Console.WriteLine("No quedan clientes por atender.");
                    break;
                }

                Console.WriteLine("\nClientes por atender:");
                foreach (string cliente in clientes)
                {
                    Console.WriteLine($"- {cliente}");
                }

                Console.Write("\n¿Desea atender al primer cliente? (si/no): ");
                string opcion = Console.ReadLine().ToLower();

                if (opcion == "si")
                {
                    string atendido = clientes.Dequeue();
                    Console.WriteLine($"Cliente atendido: {atendido}");
                }
                else if (opcion == "no")
                {
                    Console.WriteLine("Se mantiene la cola sin cambios.");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para salir.");
                    Console.ReadKey();
                    break;
                }
                

            }
            Console.ReadKey();
        }
    }
}
