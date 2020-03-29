using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LinqToSqlProject
{
    [Table]
    public class Pegawai
    {
        [Column]
        public Int32 id_pegawai;
        [Column]
        public string nama;
        [Column]
        public string posisi;
        [Column]
        public string no_telepon;
        [Column]
        public Decimal gaji;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            // membuat datacontext
            DataContext db = new DataContext(connString);

            // membuat type table
            Table<Pegawai> pegawai = db.GetTable<Pegawai>();

            // query ke database
            var _pegawai = from p in pegawai select p;

            foreach (var p in _pegawai)
            {
                Console.WriteLine("ID : {0}\nNama : {1}\nPosisi : {2} \nTelepon : {3}\nGaji : {4}", p.id_pegawai, p.nama, p.posisi, p.no_telepon, p.gaji);
            }

            Console.ReadLine();
        }
    }
}
