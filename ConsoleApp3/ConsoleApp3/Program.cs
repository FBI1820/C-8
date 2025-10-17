using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se crea una pila con capacidad de 5 elementos
            Pila pila = new Pila(5);
            pila.Push(10);   
            pila.Push(20);    
            pila.Peek();      
            pila.Pop();        

            // Se crea una cola con capacidad de 5 elementos
            Cola cola = new Cola(5);
            cola.Enqueue(10);  
            cola.Enqueue(20);  
            cola.Peek();       
            cola.Dequeue();    

            // Espera una tecla para finalizar la ejecución
            Console.ReadKey();
        }

        // Clase que representa una pila (estructura LIFO)
        class Pila
        {
            private int[] elementos; // Arreglo que almacena los elementos
            private int tope;        // Índice del último elemento agregado
            private int capacidad;   // Capacidad máxima de la pila

            // Constructor que inicializa la pila con un tamaño dado
            public Pila(int tamaño)
            {
                capacidad = tamaño;
                elementos = new int[capacidad];
                tope = -1; // Inicialmente la pila está vacía
            }

            // Verifica si la pila está vacía
            public bool EstaVacia() => tope == -1;

            // Verifica si la pila está llena
            public bool EstaLlena() => tope == capacidad - 1;

            // Agrega un elemento a la pila
            public void Push(int valor)
            {
                if (EstaLlena())
                {
                    Console.WriteLine("La pila está llena.");
                    return;
                }
                elementos[++tope] = valor;
                Console.WriteLine($"Se agregó {valor} a la pila.");
            }

            // Elimina el elemento en la cima de la pila
            public void Pop()
            {
                if (EstaVacia())
                {
                    Console.WriteLine("La pila está vacía.");
                    return;
                }
                Console.WriteLine($"Se eliminó {elementos[tope--]} de la pila.");
            }

            // Muestra el elemento en la cima sin eliminarlo
            public void Peek()
            {
                if (EstaVacia())
                {
                    Console.WriteLine("La pila está vacía.");
                    return;
                }
                Console.WriteLine($"Elemento en la cima: {elementos[tope]}");
            }
        }

        // Clase que representa una cola (estructura FIFO)
        class Cola
        {
            private int[] elementos; // Arreglo que almacena los elementos
            private int frente;      // Índice del primer elemento en la cola
            private int final;       // Índice del último elemento agregado
            private int capacidad;   // Capacidad máxima de la cola

            // Constructor que inicializa la cola con un tamaño dado
            public Cola(int tamaño)
            {
                capacidad = tamaño;
                elementos = new int[capacidad];
                frente = 0;   // El frente comienza en la posición 0
                final = -1;   // La cola está inicialmente vacía
            }

            // Verifica si la cola está vacía
            public bool EstaVacia() => frente > final;

            // Verifica si la cola está llena
            public bool EstaLlena() => final == capacidad - 1;

            // Agrega un elemento al final de la cola
            public void Enqueue(int valor)
            {
                if (EstaLlena())
                {
                    Console.WriteLine("La cola está llena.");
                    return;
                }
                elementos[++final] = valor;
                Console.WriteLine($"Se agregó {valor} a la cola.");
            }

            // Elimina el elemento al frente de la cola
            public void Dequeue()
            {
                if (EstaVacia())
                {
                    Console.WriteLine("La cola está vacía.");
                    return;
                }
                Console.WriteLine($"Se eliminó {elementos[frente++]} de la cola.");
            }

            // Muestra el elemento al frente sin eliminarlo
            public void Peek()
            {
                if (EstaVacia())
                {
                    Console.WriteLine("La cola está vacía.");
                    return;
                }
                Console.WriteLine($"Elemento al frente: {elementos[frente]}");
            }
        }
    }
}

