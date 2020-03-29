using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Bapak
    {
        // PRIVATE control access
        private string namaIndividu = "Bpk. Budiyono";

        // PROTECTED control access
        protected string alamatRumah = "Jl. Sumatra No.77";
    }

    // Class Inheritance
    class Anak : Bapak
    {
        private string namaIndividu = "Amir Zaki";

        public string AlamatRumah()
        {
            // Protected access
            return alamatRumah;
        }
    }

    class Lingkaran
    {
        private int jari2;

        // default constructor
        public Lingkaran()
        {
            jari2 = 0;
        }

        // overloading constructor
        public Lingkaran(int _jari2)
        {
            jari2 = _jari2;
        }

        public double Keliling()
        {
            return Math.PI * jari2 * jari2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran _lingkaran = new Lingkaran();
            Console.WriteLine(_lingkaran.Keliling().ToString());

            Lingkaran _lingkaran2 = new Lingkaran(20);
            Console.WriteLine(_lingkaran2.Keliling().ToString());

            Console.ReadLine();
        }
    }
}
