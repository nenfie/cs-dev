using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControlProject
{
    public partial class FrmRuntimeControl : Form
    {
        public FrmRuntimeControl()
        {
            InitializeComponent();
        }

        private void FrmRuntimeControl_Load(object sender, EventArgs e)
        {
            Label _label = new Label();
            _label.Text = "Label Runtime";
            _label.Visible = true;
            _label.AutoSize = true;
            _label.Location = new System.Drawing.Point(13, 13);

            TextBox _textbox1 = new TextBox();
            _textbox1.Text = "Textbox Runtime";
            _textbox1.Visible = true;
            _textbox1.Size = new System.Drawing.Size(150, 20);
            _textbox1.Location = new System.Drawing.Point(100, 13);

            Button _button1 = new Button();
            _button1.Text = "Button Runtime";
            _button1.Visible = true;
            _button1.Location = new System.Drawing.Point(13, 50);
            _button1.AutoSize = true;
            _button1.Click += new System.EventHandler(DisplayMessage);

            this.Controls.Add(_textbox1);
            this.Controls.Add(_label);
            this.Controls.Add(_button1);
        }

        private void DisplayMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Display Message dari Button");
        }


    }
}
