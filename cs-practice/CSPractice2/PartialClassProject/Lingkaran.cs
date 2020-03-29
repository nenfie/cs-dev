using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassProject
{
    partial class Lingkaran
    {
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
    }

}
