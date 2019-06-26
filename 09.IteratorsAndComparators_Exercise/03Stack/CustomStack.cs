using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {     
        public Stack<T> stack;

        public CustomStack()
        {
            stack = new Stack<T>();
        }

        public void Push(T item)
        {
            stack.Push(item);
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                stack.Pop();

            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
