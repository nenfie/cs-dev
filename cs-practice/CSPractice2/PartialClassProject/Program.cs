using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran _lingkaran = new Lingkaran(20);
            Console.WriteLine(_lingkaran.Keliling().ToString());

            // using Static Method
            Console.WriteLine(Lingkaran.Keliling(20));

            Console.ReadLine();
        }
    }
}
