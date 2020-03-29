using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParsingDataThreadProject2
{
    class Program
    {
        public class MyClass
        {
            private string myData;

            public MyClass(string data)
            {
                this.myData = data;
            }

            public void MyMethod()
            {
                Console.WriteLine(myData);
            }

        }

        static void Main(string[] args)
        {
            MyClass obj = new MyClass("Tes passing data");
            Thread tThreadWithParam = new Thread(obj.MyMethod);
            tThreadWithParam.Start();

            Console.ReadLine();
        }
    }
}
