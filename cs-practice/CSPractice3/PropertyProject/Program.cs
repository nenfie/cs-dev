using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyProject
{
    class Pegawai
    {
        private DateTime _tanggalLahir = DateTime.MinValue;

        private string _statusPegawai = "Permanen";

        private bool _menikah = false;

        private static DateTime CheckTanggal(DateTime date)
        {
            if (date == DateTime.MinValue)
            {
                throw new ArgumentOutOfRangeException("Error");
            }

            return date;
        }

        // Class Property
        public string Nama
        {
            get;
            set;
        }

        // Class Property with logic
        public DateTime TanggalLahir
        {
            get
            {
                return this._tanggalLahir;
            }
            set
            {

                this._tanggalLahir = CheckTanggal(value);
            }
        }

        // Read Only Property
        public string StatusPegawai
        {
            get
            {
                return _statusPegawai;
            }
        }

        // Write Only Property
        public bool Menikah
        {
            set
            {
                this._menikah = value;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // initialize class
            Pegawai _pegawai = new Pegawai();

            // assign class properties
            _pegawai.Nama ="Raymond";
            _pegawai.TanggalLahir = Convert.ToDateTime("01/12/1981");
            
            Console.WriteLine("Property Nama : " + _pegawai.Nama);
            Console.WriteLine("Property Tanggal Lahir : " + _pegawai.TanggalLahir.ToString());

            // read class properties
            string _nama = _pegawai.Nama;
            DateTime _tglLahir = _pegawai.TanggalLahir;

            // read only property
            string _status = _pegawai.StatusPegawai;

            Console.WriteLine("Property Status Pegawai : " + _pegawai.StatusPegawai.ToString());

            _pegawai.Menikah = true;

            Console.ReadLine();
        }
    }
}
