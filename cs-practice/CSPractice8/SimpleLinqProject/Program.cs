using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Jabatan = { "Programmer", "Database Administrator", "Project Manager", "Web Designer", "Database Developer" };

            IEnumerable<string> posisiIT = from posisi in Jabatan where posisi.Contains("Database") select posisi;

            foreach (var nama in posisiIT)
            {
                Console.WriteLine(nama);
            }

            Console.ReadLine();
        }
    }
}
