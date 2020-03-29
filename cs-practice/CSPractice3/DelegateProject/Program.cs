using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    class Program
    {
        public delegate void SimpleDelegate(string _str);

        public static void SimpleDelegateExample(string _str)
        {
            Console.WriteLine(_str);
        }

        public static void ExecuteMethod(SimpleDelegate e)
        {
            e("Menggunakan Delegate Function");
        }

        static void Main(string[] args)
        {
            // Direct Delegate
            SimpleDelegate del = SimpleDelegateExample;
            del("Menggunakan Delegate");

            // Indirect Delegate
            SimpleDelegate del2 = SimpleDelegateExample;
            ExecuteMethod(del2);

            Console.ReadLine();

        }
    }
}
