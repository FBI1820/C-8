using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        // 1. Declarar una pila utilizando la clase Stack<T> de C#
        Stack<int> pilaDeEnteros = new Stack<int>();
        Console.WriteLine("\t--- Simulación_Pila_Números_Enteros");

        // 2. Permitir al usuario ingresar varios números enteros para apilarlos (push)
        Console.WriteLine("\t-- (Insertar_Elementos) ---");
        Console.Write("¿Cuántos números deseas ingresar a la pila? ");

        if (int.TryParse(Console.ReadLine(), out int cantidad))
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingresa el número entero #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    pilaDeEnteros.Push(numero); // Insertar el elemento
                    Console.WriteLine($"-> {numero} insertado (PUSH).");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Se omitirá este número.");
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada de cantidad no válida. La pila se inicializará vacía.");
        }

        // 3. Mostrar los elementos actuales de la pila.
        MostrarPila(pilaDeEnteros);

        // 4. Eliminar el último elemento ingresado (pop)
        Console.WriteLine("\n--- Operación POP (Eliminar Elemento) ---");

        // 6. Comprobar si la pila está vacía o no antes de extraer un elemento.
        if (pilaDeEnteros.Count > 0) // Comprueba si hay elementos
        {
            int elementoEliminado = pilaDeEnteros.Pop(); // Eliminar el elemento superior
            Console.WriteLine($"Elemento eliminado (POP): {elementoEliminado}");
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede realizar la operación POP.");
        }

        // 5. Mostrar nuevamente la pila después de la eliminación.
        MostrarPila(pilaDeEnteros);

        // Intento de POP adicional con chequeo (para demostrar el punto 6)
        Console.WriteLine("\n--- Intento de POP Adicional con Comprobación ---");
        if (pilaDeEnteros.Count > 0)
        {
            int elementoEliminado = pilaDeEnteros.Pop();
            Console.WriteLine($"Elemento eliminado (POP): {elementoEliminado}");
        }
        else
        {
            Console.WriteLine("La pila está *ahora* vacía. No se puede realizar la operación POP.");
        }

        MostrarPila(pilaDeEnteros);
    }

    /// <summary>
    /// Muestra el contenido actual de la pila sin modificarla.
    /// <summary>
    /// <param name="pila">La pila de enteros a mostrar.</param>
    static void MostrarPila(Stack<int> pila)
    {
        Console.WriteLine("\n- Contenido Actual de la Pila ---");
        if (pila.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
        }
        else
        {
            // La función ToArray() o iterar la pila la recorre de arriba hacia abajo (Top a Bottom)
            Console.Write("Elementos (De Top/Cima a Bottom/Fondo): ");
            // Usamos string.Join para una salida limpia
            Console.WriteLine(string.Join(" -> ", pila.ToArray()));
            Console.WriteLine($"Tamaño actual de la pila: {pila.Count}");
        }
    }
}


