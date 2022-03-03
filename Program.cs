using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = new Queue<string>();
            value.Enqueue("ap");
            value.Enqueue("delhi");
            value.Enqueue("punjab");
            Console.Write("total number of elemts in the queue are :");
            Console.WriteLine(value.Count);
            Console.ReadLine();
        }
    }
}
