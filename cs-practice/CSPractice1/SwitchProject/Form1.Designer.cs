namespace SwitchProject
{
    partial class FrmSwitch
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
            this.CmbPilih = new System.Windows.Forms.ComboBox();
            this.BtnPilih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbPilih
            // 
            this.CmbPilih.FormattingEnabled = true;
            this.CmbPilih.Items.AddRange(new object[] {
            "C#",
            "VB.Net",
            "Java",
            "Delphi"});
            this.CmbPilih.Location = new System.Drawing.Point(12, 30);
            this.CmbPilih.Name = "CmbPilih";
            this.CmbPilih.Size = new System.Drawing.Size(121, 21);
            this.CmbPilih.TabIndex = 0;
            // 
            // BtnPilih
            // 
            this.BtnPilih.Location = new System.Drawing.Point(149, 30);
            this.BtnPilih.Name = "BtnPilih";
            this.BtnPilih.Size = new System.Drawing.Size(75, 23);
            this.BtnPilih.TabIndex = 1;
            this.BtnPilih.Text = "Pilih";
            this.BtnPilih.UseVisualStyleBackColor = true;
            this.BtnPilih.Click += new System.EventHandler(this.BtnPilih_Click);
            // 
            // FrmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.BtnPilih);
            this.Controls.Add(this.CmbPilih);
            this.Name = "FrmSwitch";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbPilih;
        private System.Windows.Forms.Button BtnPilih;
    }
}

