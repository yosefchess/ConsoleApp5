using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> Yossef = new LinkedList<string>();

            Yossef.AddFirst("ALOOO");
            Yossef.AddFirst("ALOO");
            Yossef.AddLast("ALOOOO");
            Yossef.AddLast("Done");

            Console.WriteLine("The linked List Before Reversing:  ");

            foreach (var item in Yossef)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("The linked List After Reversing: ");

            foreach (var item in Yossef.Reverse())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
