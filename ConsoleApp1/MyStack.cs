using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack<T>
    {
        private List<T> _stackList; // Internal list to hold stack items

        // Constructor to initialize the stack
        public MyStack()
        {
            _stackList = new List<T>();
        }

        // Push method to add an element to the stack
        public void Push(T item)
        {
            _stackList.Add(item);
        }

        // Pop method to remove and return the top element from the stack
        public T Pop()
        {
            if (_stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = _stackList[_stackList.Count - 1];
            _stackList.RemoveAt(_stackList.Count - 1);
            return item;
        }

        // Peek method to view the top element of the stack without removing it
        public T Peek()
        {
            if (_stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _stackList[_stackList.Count - 1];
        }

        // Method to check if the stack is empty
        public bool IsEmpty()
        {
            return _stackList.Count == 0;
        }

        // Method to get the count of elements in the stack
        public int Count()
        {
            return _stackList.Count;
        }
    }
}
