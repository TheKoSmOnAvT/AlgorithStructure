using System;
namespace StructureAlgorithms.structur
{
    public class Queue<T>
    {
        public Queue()
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

        public int Lenght => lenStack;

        public void Push(T element)
        {
            addElement(element);
        }
        public T Pop()
        {
            var item = stack[0];
            deleteElement();
            return item;
        }

        private void deleteElement()
        {
            var newStack = new T[lenStack - 1];
            for (int i = 0; i < lenStack - 1; i++)
            {
                newStack[i] = stack[i+1];
            }
            stack = newStack;
            lenStack -= 1;
        }

        private void addElement(T el)
        {
            var newStack = new T[lenStack + 1];
            for (int i = 0; i < lenStack; i++)
            {
                newStack[i] = stack[i];
            }
            newStack[lenStack] = el;
            stack = newStack;
            lenStack += 1;
        }
    }
}
