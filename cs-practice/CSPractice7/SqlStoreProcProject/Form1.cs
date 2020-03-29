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

namespace SqlStoreProcProject
{
    public partial class FrmStoreProc : Form
    {
        public FrmStoreProc()
        {
            InitializeComponent();
        }

        private void BtnExecuteSP_Click(object sender, EventArgs e)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            SqlConnection conn = new SqlConnection(connString);

            // membuka koneksi
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "prcPegawaiList";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
            }
        }

        private void BtnExecuteSP2_Click(object sender, EventArgs e)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            SqlConnection conn = new SqlConnection(connString);

            // membuka koneksi
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "prcPegawaiList2";

            SqlParameter inParam = cmd.Parameters.Add("@idPegawai", SqlDbType.Int);
            inParam.Direction = ParameterDirection.Input;
            inParam.Value = 2;

            SqlParameter outParam = cmd.Parameters.Add("@gaji", SqlDbType.Decimal);
            outParam.Direction = ParameterDirection.Output;

            SqlDataReader reader = cmd.ExecuteReader();

            MessageBox.Show(cmd.Parameters["@gaji"].Value.ToString());
        }
    }
}
