using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadRunningProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tNewThread = new Thread(MyMethod);
            tNewThread.Name = "My New Thread";
            tNewThread.IsBackground = false;
            tNewThread.Start();

            Console.WriteLine("Main Thread ending now");

            Console.ReadLine();
        }

        static void MyMethod()
        {
            Console.WriteLine("New Thread Start");

            Thread.Sleep(3000);
            Console.WriteLine("New Thread End");
        }
    }
}
