using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LinqToSqlProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            // membuat datacontext
            DataContext db = new DataContext(connString);

            string query = "INSERT INTO Divisi (nama_divisi, id_manager) VALUES ('Humas',1)";

            // mengeksekusi query
            db.ExecuteCommand(query);

            Console.ReadLine();
        }
    }
}
