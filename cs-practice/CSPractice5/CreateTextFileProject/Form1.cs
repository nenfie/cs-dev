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

namespace CreateTextFileProject
{
    public partial class FrmCreateTextFile : Form
    {
        public FrmCreateTextFile()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string _stringTemp = string.Empty;

            try
            {
                FileStream file = new FileStream(@"C:\Database\CreateFileFromDotNet.txt",FileMode.OpenOrCreate,FileAccess.Write);
                StreamWriter sw = new StreamWriter(file);

                foreach( string s in TxtCreate.Lines)
                {
                    sw.Write(s + "\r\n");
                }

                sw.Close();
                file.Close();
                MessageBox.Show (_stringTemp);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
