using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProject
{
    public partial class FrmSwitch : Form
    {
        public FrmSwitch()
        {
            InitializeComponent();
        }

        private void BtnPilih_Click(object sender, EventArgs e)
        {
            // SWITCH Condition
            switch (CmbPilih.Text)
            {
                case "C#": 
                    MessageBox.Show("Anda memilih C#");
                    break;

                case "VB.Net":
                    MessageBox.Show("Anda memilih VB.Net");
                    break;

                case "Java":
                    MessageBox.Show("Anda memilih Java");
                    break;

                case "Delphi":
                    MessageBox.Show("Anda memilih Delphi");
                    break;

                default:
                    MessageBox.Show("Anda belum memilih");
                    break;
            }
        }
    }
}
