using System;
namespace StructureAlgorithms.structur
{
    public class Stack<T>
    {
        public Stack()
        {
            lenStack = 0;
            stack = new T[lenStack];
        }

        private int lenStack;

        private T[] stack;

        public bool isEmpty()
        {
            if (lenStack > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int Lenght
        {
            get
            {
                return lenStack;
            }
        }

        public void Push(T element)
        {
            addElement(element);
        }
        public T Pop()
        {
           var item = stack[lenStack-1];
           deleteLast();
           return item;
        }

        private void deleteLast()
        {
            var newStack= new T[lenStack-1];
            for (int i = 0; i< lenStack - 1; i++)
            {
                newStack[i] = stack[i];
            }
            stack = newStack;
            lenStack -= 1;
        }

        private void addElement(T el)
        {
            var newStack = new T[lenStack + 1];
            for (int i = 0; i < lenStack ; i++)
            {
                newStack[i] = stack[i];
            }
            newStack[lenStack] = el;
            stack = newStack;
            lenStack += 1;
        }
    }
}
