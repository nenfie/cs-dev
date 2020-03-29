using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModifiedFileProject
{
    public partial class FrmModifiedFile : Form
    {
        public FrmModifiedFile()
        {
            InitializeComponent();
        }

        private void BtnCopyFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(TxtDestination.Text))
                {
                    File.Copy(TxtSource.Text, TxtDestination.Text);
                    MessageBox.Show("File telah dicopy");
                }
                else
                {
                    MessageBox.Show("File telah ada pada Directory tersebut");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BtnMovingFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(TxtDestination.Text))
                {
                    File.Move(TxtSource.Text, TxtDestination.Text);
                    MessageBox.Show("File telah dipindahkan");
                }
                else
                {
                    MessageBox.Show("File telah ada pada Directory tersebut");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void BtnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(TxtDestination.Text);
                MessageBox.Show("File telah dihapus");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
