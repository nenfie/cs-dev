using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinqToObjectProject
{
    class Program
    {
        class Pegawai
        {
            public string Nama
            {
                get;
                set;
            }

            public string Alamat
            {
                get;
                set;
            }

            public Double Gaji
            {
                get;
                set;
            }
        }

        static void Main(string[] args)
        {
            // mendefinisikan Object Pegawai dan Initialize
            // value
            Pegawai _pegawaiDomain = new Pegawai();
            _pegawaiDomain.Nama = "Teddy Syahputra";
            _pegawaiDomain.Alamat = " Jl. Kepompong Selatan";
            _pegawaiDomain.Gaji = 3500000;

            Pegawai _pegawaiDomain2 = new Pegawai();
            _pegawaiDomain2.Nama = "Antony Siregar";
            _pegawaiDomain2.Alamat = "Jl. Simprug Rawa";
            _pegawaiDomain2.Gaji = 4000000;

            Pegawai _pegawaiDomain3 = new Pegawai();
            _pegawaiDomain3.Nama = "Boby Nugraha";
            _pegawaiDomain3.Alamat = "Jl. Keadilan Raya";
            _pegawaiDomain3.Gaji = 5000000;

            ArrayList _list = new ArrayList();
            _list.Add(_pegawaiDomain);
            _list.Add(_pegawaiDomain2);
            _list.Add(_pegawaiDomain3);

            // LINQ
            var _pegawai = from Pegawai p in _list select p;

            foreach (Pegawai p in _pegawai)
            {
                Console.WriteLine(p.Nama + " " + p.Alamat + " " + p.Gaji.ToString());
            }

            Console.ReadLine();
        }
    }
}
