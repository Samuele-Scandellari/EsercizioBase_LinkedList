using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CastomLinkedList
    {
        private Nodo head;

        public void AggiungiUltimo(int data)
        {
            Nodo newNodo = new Nodo(data);

            if (head == null)
            {
                head = newNodo;
                return;
            }

            Nodo ultimo = head;

            while (ultimo.Next != null)
            {
                ultimo = ultimo.Next;
            }

            ultimo.Next = newNodo;
        }

        public void AggiungiPrimo(int data)
        {
            Nodo newNodo = new Nodo(data);
            newNodo.Next = head;
            head = newNodo;
        }

        public bool Rimuovi(int key)
        {
            Nodo temp = head, prev = null;

            if (temp != null && temp.Data == key)
            {
                head = temp.Next;
                return true;
            }

            while (temp != null && temp.Data != key)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null) return false;

            prev.Next = temp.Next;
            return true;
        }

        public void Display()
        {
            Nodo current = head;
            Console.Write("Lista: ");
            while (current != null)
            {
                Console.Write($"{current.Data} --> ");
                current = current.Next;
            }

            Console.WriteLine("NULL");
        }
    }
}