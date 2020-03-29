using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProject
{
    class Program
    {
        private string _message = string.Empty;

        // Return value Method
        public int Angka()
        {
            int _angka = int.MinValue;
            return _angka;
        }

        // Non-Return value Method
        public void Message()
        {
            _message = "Method Project";
        }

        public string MessageOutput()
        {
            this.Message();
            return _message;
        }

        // Method with Parameter Input
        public int Angka2(int _angka)
        {
            _angka = _angka * 3;

            return _angka;
        }

        static void Main(string[] args)
        {
            Program a = new Program();

            Console.WriteLine(a.Angka().ToString());

            Console.WriteLine(a.MessageOutput());

            Console.WriteLine(a.Angka2(3).ToString());

            Console.ReadLine();

        }
    }
}
