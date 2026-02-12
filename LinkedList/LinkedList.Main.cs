using System;
using System.Threading.Channels;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CastomLinkedList lista = new CastomLinkedList();

            Console.WriteLine("--- Test Linked List --- \n");

            lista.AggiungiUltimo(10);
            lista.AggiungiUltimo(20);
            lista.AggiungiPrimo(5);
            lista.AggiungiUltimo(30);

            lista.Display();

            Console.WriteLine("\nRimozione del 20...");
            lista.Rimuovi(20);
            lista.Display();

            Console.WriteLine("\nRimozione del 5...");
            lista.Rimuovi(5);
            lista.Display();
        }
    }
}