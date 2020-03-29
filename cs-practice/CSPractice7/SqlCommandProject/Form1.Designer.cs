namespace SqlCommandProject
{
    partial class FrmPegawai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LvPegawai = new System.Windows.Forms.ListView();
            this.BtnRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvPegawai
            // 
            this.LvPegawai.Location = new System.Drawing.Point(4, 12);
            this.LvPegawai.Name = "LvPegawai";
            this.LvPegawai.Size = new System.Drawing.Size(468, 150);
            this.LvPegawai.TabIndex = 0;
            this.LvPegawai.UseCompatibleStateImageBehavior = false;
            // 
            // BtnRetrieve
            // 
            this.BtnRetrieve.Location = new System.Drawing.Point(4, 177);
            this.BtnRetrieve.Name = "BtnRetrieve";
            this.BtnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.BtnRetrieve.TabIndex = 1;
            this.BtnRetrieve.Text = "Retrieve";
            this.BtnRetrieve.UseVisualStyleBackColor = true;
            this.BtnRetrieve.Click += new System.EventHandler(this.BtnRetrieve_Click);
            // 
            // FrmPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.BtnRetrieve);
            this.Controls.Add(this.LvPegawai);
            this.Name = "FrmPegawai";
            this.Text = "Pegawai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvPegawai;
        private System.Windows.Forms.Button BtnRetrieve;
    }
}

