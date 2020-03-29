using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlCommandBuilderProject
{
    public partial class FrmPegawai : Form
    {
        public FrmPegawai()
        {
            InitializeComponent();
        }

        private void BtnRetrieve_Click(object sender, EventArgs e)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            // membuat koneksi
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // membuka koneksi
                conn.Open();

                string cmd = "SELECT * FROM Pegawai";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, connString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // menampilkan ke data grid
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                DgvPegawai.DataSource = table;
            }
            catch (SqlException ex)
            {
                // menampilkan error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // menutup koneksi
                conn.Close();
            }
        }
    }
}
