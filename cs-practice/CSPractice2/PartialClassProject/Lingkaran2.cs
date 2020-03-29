using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassProject
{
    partial class Lingkaran
    {
        private int jari2;

        public double Keliling()
        {
            return Math.PI * jari2 * jari2;
        }

        // STATIC METHOD
        static public double Keliling(int _jari2)
        {
            return Math.PI * _jari2 * _jari2;
        }

    }
}
