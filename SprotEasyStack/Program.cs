using SprotEasyStack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotEasyStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            EasyStack<int> easyStack = new EasyStack<int>();

            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);
            var item =easyStack.Pop();
            var item2 = easyStack.Peek();
            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadLine();
        }
    }
}
