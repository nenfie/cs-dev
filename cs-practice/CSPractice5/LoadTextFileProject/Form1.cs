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

namespace LoadTextFileProject
{
    public partial class FrmLoadTextFile : Form
    {
        public FrmLoadTextFile()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(TxtPath.Text, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {
                    string _tempString = string.Empty; 
                    _tempString = sr.ReadLine();
                    TxtLoadData.Text = TxtLoadData.Text + _tempString + "\r\n";
                }

                sr.Close();
                file.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
