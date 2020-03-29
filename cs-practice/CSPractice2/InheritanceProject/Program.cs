using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{   
    // Base Class
    class Bapak
    {
        private string _alamatRumah = "Jl. Kepompong No.77";

        private string _tempatLahir = "Bogor";

        public string AlamatRumah()
        {
            return _alamatRumah;
        }

        // Overloading method
        public string AlamatRumah(string _alamatRumah)
        {
            return _alamatRumah;
        }

        // Overide Method
        public virtual string TempatLahir()
        {
            return _tempatLahir;
        }
    }

    // Derived Class
    class Anak : Bapak
    {
        private string _stylePakaian = "Modern";

        public string StylePakaian()
        {
            return _stylePakaian;
        }

        // Overidden Method
        public override string TempatLahir()
        {
            return "Jakarta";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Anak _anak = new Anak();

            Console.WriteLine(_anak.AlamatRumah());

            Console.WriteLine(_anak.AlamatRumah("Jl. Kemerdekaan"));

            Console.WriteLine(_anak.StylePakaian());

            Console.WriteLine(_anak.TempatLahir());

            Console.ReadLine();
        }
    }
}
