using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(25);
            stack.Push(50);
            stack.Push(100);
            stack.Push(300);
            stack.Push(37);
            stack.Print();
            stack.Count();
            stack.Pop();
            stack.Print();
            stack.Count();
            stack.Pop();
            stack.Print();
            stack.Count();
            stack.Pop();
            stack.Print();
            stack.Count();
            
            stack.Clear();
            stack.Print();

            Stack<string> stack2 = new Stack<string>(10);
            stack2.Push("Hello");
            stack2.Push("how");
            stack2.Push("are");
            stack2.Push("you");
            stack2.Push("doing");
            stack2.Print();
            stack2.Count();
            stack2.Pop();
            stack2.Print();
            stack2.Count();

        
            Console.WriteLine("\n");
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
