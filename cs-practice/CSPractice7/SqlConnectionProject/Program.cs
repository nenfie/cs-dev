using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlConnectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005; user=sa; password=awizindo;";

            // membuat koneksi
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                // membuka koneksi
                conn.Open();
                Console.WriteLine("Terhubung ke database");
            }
            catch (SqlException e)
            {
                // menampilkan error
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // menutup koneksi
                conn.Close();
                Console.WriteLine("Koneksi ditutup");
            }

            Console.ReadLine();
        }
    }
}
