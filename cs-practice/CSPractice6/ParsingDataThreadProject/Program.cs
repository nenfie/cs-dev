using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParsingDataThreadProject
{
    class Program
    {
        public struct Data
        {
            public string Message;
        }

        static void Main(string[] args)
        {
            Data myData = new Data();
            myData.Message = "Tes passing data";

            Thread tThreadWithParam = new Thread(new ParameterizedThreadStart(MyMethodWithParam));
            tThreadWithParam.Start(myData);

            Console.WriteLine("This is Main Thread");

            Console.ReadLine();
        }

        static void MyMethodWithParam(object obj)
        {
            Data d = (Data)obj;
            Console.WriteLine("New Thread Data : " + d.Message);
        }
    }
}
