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

namespace SqlCommandProject
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
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=hrd;";

            // membuat koneksi
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // membuka koneksi
                conn.Open();

                string cmd = "SELECT nama, email, no_telepon FROM Pegawai";

                SqlCommand command = new SqlCommand(cmd, conn);

                SqlDataReader dataReader = command.ExecuteReader();

                // index untuk listview
                int ind = 0;

                // menampilkan ke listview
                LvPegawai.Columns.Add("Nama");
                LvPegawai.Columns.Add("Email");
                LvPegawai.Columns.Add("No Telepon");

                while (dataReader.Read())
                {
                    LvPegawai.Items.Add(dataReader.GetValue(0).ToString());
                    LvPegawai.Items[ind].SubItems.Add(dataReader.GetValue(1).ToString());
                    LvPegawai.Items[ind].SubItems.Add(dataReader.GetValue(2).ToString());
                    ind = ind + 1;
                }
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
