using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpWeek4
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = this.head;
            while (node != null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
        
    }


    class Program
    {
        public static void GenericListTest()
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            //print list
            list.ForEach(i => Console.WriteLine(i));

            int max = int.MinValue;
            list.ForEach(i => { if (max < i) max = i; });
            Console.WriteLine("Max:" + max);

            int min = int.MaxValue;
            list.ForEach(i => { if (min > i) min = i; });
            Console.WriteLine("Min:" + min);

            int sum = 0;
            list.ForEach(i => { sum += i; });
            Console.WriteLine("Sum:" + sum);
        }

        public static void ClockTest()
        {

        }

        static void Main(string[] args)
        {
            GenericListTest();
        }
    }


}
