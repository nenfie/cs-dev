using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadSimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tNewThread = new Thread(MyMethod);
            tNewThread.Name = "My Thread";
            tNewThread.Start();

            Console.WriteLine("This is Main Thread");

            Console.ReadLine();
        }

        static void MyMethod()
        {
            Console.WriteLine("This is New Thread, Name is : " + Thread.CurrentThread.Name);
        }
    }
}
