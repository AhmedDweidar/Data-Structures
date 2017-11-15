using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Stack<T> 
    {
        int _top; // holds the index for item at the top of the stack
        int _stackSize;
        List<T> list; 

        public Stack(int size)
        {
            list = new List<T>();
            _stackSize = size;
            _top = -1;
        }

        public void Push(T item)
        {
            if (_top < _stackSize - 1) // check to see if the stack is full (otherwise push item onto stack)
            {
                _top++;
                list.Add(item);
            }
            else
            {
                Console.Write("The stack is full, can't push item \n");
            }
        }

        public void Pop()
        {
            //int count = list.Count();

            // check first to see if the stack is empty
            if (_top == -1) 
            {
                Console.Write("Error: Stack is empty, no items to pop \n");
            }
            else
            {
                Console.WriteLine("Item popped: {0}", list[_top]);
                list.Remove(list[_top]);
                _top--;
                //Console.Write("Number of items in stack: {0} \n", count);
            }   
        }

        public void Peek()
        {
            // check first to see if the stack is empty
            if (_top == -1) 
            {
                Console.Write("Error: Stack is empty, no items to peek \n");
            }
            else
            {
                Console.WriteLine("The item at the top of the stack is: {0}", list[_top]); // otherwise, pop item at top
            }
        }

        // method to print the current stack
        public void Print()
        {
            // check first to see if the stack is empty
            if (_top == -1)
            {
                Console.Write("Error: Stack is empty, no items to display \n");
            }
            else
            {
                Console.WriteLine("The current stack is:");

                for (int i = _top; i > -1; i--)
                {
                    Console.WriteLine("Item {0}: {1}", (i + 1), list[i]);
                }
            }
        }

        // method to return number of items in stack
        public void Count()
        {
            Console.Write("Number of items in stack: {0} \n", list.Count());
        }

        // method to clear the current stack stack
        public void Clear()
        {
            list.Clear();
            _top = -1;
            Console.WriteLine("The stack is cleared");
        }
    }
}
