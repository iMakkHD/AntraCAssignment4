using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;

        public MyStack(int cap)
        {
            capacity = cap;
            stack = new T[capacity];
        }
        public void count(){

        }

        public int push(T item)
        {
            if(top == capacity - 1)
            {
                return -1;
            }
            else
            {
                top = top + 1;
                stack[top] = item;
            }
            return 0;
        }

        public T pop()
        {
            T Removed;
            T temp = default(T);
            if (!(top <= 0))
            {
                Removed = stack[top];
                top = top - 1;
                return Removed;
            }
            return temp;
        }

    }
}
