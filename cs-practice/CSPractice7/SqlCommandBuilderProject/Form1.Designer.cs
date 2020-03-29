namespace SqlCommandBuilderProject
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
            this.DgvPegawai = new System.Windows.Forms.DataGridView();
            this.BtnRetrieve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPegawai
            // 
            this.DgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPegawai.Location = new System.Drawing.Point(12, 12);
            this.DgvPegawai.Name = "DgvPegawai";
            this.DgvPegawai.Size = new System.Drawing.Size(450, 150);
            this.DgvPegawai.TabIndex = 0;
            // 
            // BtnRetrieve
            // 
            this.BtnRetrieve.Location = new System.Drawing.Point(12, 177);
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
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.BtnRetrieve);
            this.Controls.Add(this.DgvPegawai);
            this.Name = "FrmPegawai";
            this.Text = "Pegawai";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPegawai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPegawai;
        private System.Windows.Forms.Button BtnRetrieve;
    }
}

