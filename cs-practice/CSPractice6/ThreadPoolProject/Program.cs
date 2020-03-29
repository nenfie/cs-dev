using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(MyMethod);
            Thread.Sleep(50);

            Console.ReadLine();
        }

        static void MyMethod(object o)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop{0}, running inside pooled thread {1}", i, Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
