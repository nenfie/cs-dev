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

namespace SqlModifyDataProject
{
    public partial class FrmCreateDivisi : Form
    {
        public FrmCreateDivisi()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // connection string
            string connString = @"server=POSDEV-PC\SQL2005;user=sa;password=awizindo;database=Hrd;";

            // membuat koneksi
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // membuka koneksi
                conn.Open();
            }
            catch (SqlException exp)
            {
                string a = exp.Message;
            }

            SqlTransaction sqlTran = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                StringBuilder cmd = new StringBuilder();
                cmd.Append("INSERT INTO Divisi VALUES (");
                cmd.Append("'" + TxtNamaDivisi.Text + "'," + TxtIdManager.Text);
                cmd.Append(")");

                SqlCommand command = new SqlCommand(cmd.ToString(), conn);
                command.Transaction = sqlTran;
                command.ExecuteNonQuery();

                sqlTran.Commit();
            }
            catch (SqlException ex)
            {
                sqlTran.Rollback();

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
