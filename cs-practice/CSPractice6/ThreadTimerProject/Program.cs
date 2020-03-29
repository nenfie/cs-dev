using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTimerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(MyMethod, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3));

            Thread.Sleep(30000);
            t.Dispose();

            Console.ReadLine();
        }

        static void MyMethod(object o)
        {
            Console.WriteLine("System.Threading.TImer{0:T}", DateTime.Now);
        }

    }
}
