using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControlProject
{
    public partial class FrmCommonControl : Form
    {
        public FrmCommonControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username : " + TxtUsername.Text + "\nPassword : " + TxtPassword.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
