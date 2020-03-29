using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionProject
{
    public partial class FrmCondition : Form
    {
        public FrmCondition()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int angka = int.Parse(TxtAngka.Text);

            // IF Condition
            if (angka > 100)
            {
                // Nested IF
                if (angka == 120)
                {
                    MessageBox.Show("Angka sama dengan 120");
                }
                else
                {
                    MessageBox.Show("Angka lebih besar dari 100");
                }
            }

            // ELSE Condition
            else
            {
                MessageBox.Show("Angka lebih kecil atau sama dengan 100");
            }
        }
    }
}
