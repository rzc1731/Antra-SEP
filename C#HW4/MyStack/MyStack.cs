// See https://aka.ms/new-console-template for more information
using System;

namespace MyStack
{
    public class MyStack
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine(myStack.Count());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Count());
        }
    }

    public class MyStack<T>
    {
        private List<T> data = new List<T>();

        public int Count()
        {
            return data.Count;
        }
        public void Push(T element)
        {
            data.Add(element);
        }

        public T Pop()
        {
            T element = data[0];
            data.RemoveAt(0);
            return element;
        }
    }
}

