namespace CommonControlProject2
{
    partial class FrmCommonControl2
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
            this.LblPemrograman = new System.Windows.Forms.Label();
            this.LblHari = new System.Windows.Forms.Label();
            this.CmbPemrograman = new System.Windows.Forms.ComboBox();
            this.RbtSeninRabu = new System.Windows.Forms.RadioButton();
            this.RbtSelasaKamis = new System.Windows.Forms.RadioButton();
            this.RbtSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.LblSkill = new System.Windows.Forms.Label();
            this.ChkMicrosoft = new System.Windows.Forms.CheckBox();
            this.ChkOracle = new System.Windows.Forms.CheckBox();
            this.ChkSun = new System.Windows.Forms.CheckBox();
            this.ChkIBM = new System.Windows.Forms.CheckBox();
            this.LblJam = new System.Windows.Forms.Label();
            this.LstJamKursus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblPemrograman
            // 
            this.LblPemrograman.AutoSize = true;
            this.LblPemrograman.Location = new System.Drawing.Point(13, 13);
            this.LblPemrograman.Name = "LblPemrograman";
            this.LblPemrograman.Size = new System.Drawing.Size(94, 13);
            this.LblPemrograman.TabIndex = 0;
            this.LblPemrograman.Text = "Pilih Pemrograman";
            // 
            // LblHari
            // 
            this.LblHari.AutoSize = true;
            this.LblHari.Location = new System.Drawing.Point(13, 39);
            this.LblHari.Name = "LblHari";
            this.LblHari.Size = new System.Drawing.Size(83, 13);
            this.LblHari.TabIndex = 1;
            this.LblHari.Text = "Pilih Hari Kursus";
            // 
            // CmbPemrograman
            // 
            this.CmbPemrograman.FormattingEnabled = true;
            this.CmbPemrograman.Items.AddRange(new object[] {
            "C#",
            "VB.Net",
            "C++",
            "Delphi",
            "Java"});
            this.CmbPemrograman.Location = new System.Drawing.Point(136, 13);
            this.CmbPemrograman.Name = "CmbPemrograman";
            this.CmbPemrograman.Size = new System.Drawing.Size(121, 21);
            this.CmbPemrograman.TabIndex = 2;
            // 
            // RbtSeninRabu
            // 
            this.RbtSeninRabu.AutoSize = true;
            this.RbtSeninRabu.Location = new System.Drawing.Point(136, 40);
            this.RbtSeninRabu.Name = "RbtSeninRabu";
            this.RbtSeninRabu.Size = new System.Drawing.Size(87, 17);
            this.RbtSeninRabu.TabIndex = 3;
            this.RbtSeninRabu.TabStop = true;
            this.RbtSeninRabu.Text = "Senin - Rabu";
            this.RbtSeninRabu.UseVisualStyleBackColor = true;
            // 
            // RbtSelasaKamis
            // 
            this.RbtSelasaKamis.AutoSize = true;
            this.RbtSelasaKamis.Location = new System.Drawing.Point(136, 63);
            this.RbtSelasaKamis.Name = "RbtSelasaKamis";
            this.RbtSelasaKamis.Size = new System.Drawing.Size(94, 17);
            this.RbtSelasaKamis.TabIndex = 4;
            this.RbtSelasaKamis.TabStop = true;
            this.RbtSelasaKamis.Text = "Selasa - Kamis";
            this.RbtSelasaKamis.UseVisualStyleBackColor = true;
            // 
            // RbtSabtuMinggu
            // 
            this.RbtSabtuMinggu.AutoSize = true;
            this.RbtSabtuMinggu.Location = new System.Drawing.Point(136, 86);
            this.RbtSabtuMinggu.Name = "RbtSabtuMinggu";
            this.RbtSabtuMinggu.Size = new System.Drawing.Size(97, 17);
            this.RbtSabtuMinggu.TabIndex = 5;
            this.RbtSabtuMinggu.TabStop = true;
            this.RbtSabtuMinggu.Text = "Sabtu - Minggu";
            this.RbtSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // LblSkill
            // 
            this.LblSkill.AutoSize = true;
            this.LblSkill.Location = new System.Drawing.Point(13, 116);
            this.LblSkill.Name = "LblSkill";
            this.LblSkill.Size = new System.Drawing.Size(94, 13);
            this.LblSkill.TabIndex = 6;
            this.LblSkill.Text = "Skill Pemrograman";
            // 
            // ChkMicrosoft
            // 
            this.ChkMicrosoft.AutoSize = true;
            this.ChkMicrosoft.Location = new System.Drawing.Point(136, 116);
            this.ChkMicrosoft.Name = "ChkMicrosoft";
            this.ChkMicrosoft.Size = new System.Drawing.Size(133, 17);
            this.ChkMicrosoft.TabIndex = 7;
            this.ChkMicrosoft.Text = "Microsoft Programming";
            this.ChkMicrosoft.UseVisualStyleBackColor = true;
            // 
            // ChkOracle
            // 
            this.ChkOracle.AutoSize = true;
            this.ChkOracle.Location = new System.Drawing.Point(136, 139);
            this.ChkOracle.Name = "ChkOracle";
            this.ChkOracle.Size = new System.Drawing.Size(121, 17);
            this.ChkOracle.TabIndex = 8;
            this.ChkOracle.Text = "Oracle Programming";
            this.ChkOracle.UseVisualStyleBackColor = true;
            // 
            // ChkSun
            // 
            this.ChkSun.AutoSize = true;
            this.ChkSun.Location = new System.Drawing.Point(136, 162);
            this.ChkSun.Name = "ChkSun";
            this.ChkSun.Size = new System.Drawing.Size(109, 17);
            this.ChkSun.TabIndex = 9;
            this.ChkSun.Text = "Sun Programming";
            this.ChkSun.UseVisualStyleBackColor = true;
            // 
            // ChkIBM
            // 
            this.ChkIBM.AutoSize = true;
            this.ChkIBM.Location = new System.Drawing.Point(136, 185);
            this.ChkIBM.Name = "ChkIBM";
            this.ChkIBM.Size = new System.Drawing.Size(109, 17);
            this.ChkIBM.TabIndex = 10;
            this.ChkIBM.Text = "IBM Programming";
            this.ChkIBM.UseVisualStyleBackColor = true;
            // 
            // LblJam
            // 
            this.LblJam.AutoSize = true;
            this.LblJam.Location = new System.Drawing.Point(13, 211);
            this.LblJam.Name = "LblJam";
            this.LblJam.Size = new System.Drawing.Size(61, 13);
            this.LblJam.TabIndex = 11;
            this.LblJam.Text = "Jam Kursus";
            // 
            // LstJamKursus
            // 
            this.LstJamKursus.FormattingEnabled = true;
            this.LstJamKursus.Items.AddRange(new object[] {
            "Jam 09.00 - 11.00",
            "Jam 11.00 - 13.00",
            "Jam 13.00 - 15.00",
            "Jam 15.00 - 17.00"});
            this.LstJamKursus.Location = new System.Drawing.Point(136, 211);
            this.LstJamKursus.Name = "LstJamKursus";
            this.LstJamKursus.Size = new System.Drawing.Size(120, 82);
            this.LstJamKursus.TabIndex = 12;
            // 
            // FrmCommonControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 313);
            this.Controls.Add(this.LstJamKursus);
            this.Controls.Add(this.LblJam);
            this.Controls.Add(this.ChkIBM);
            this.Controls.Add(this.ChkSun);
            this.Controls.Add(this.ChkOracle);
            this.Controls.Add(this.ChkMicrosoft);
            this.Controls.Add(this.LblSkill);
            this.Controls.Add(this.RbtSabtuMinggu);
            this.Controls.Add(this.RbtSelasaKamis);
            this.Controls.Add(this.RbtSeninRabu);
            this.Controls.Add(this.CmbPemrograman);
            this.Controls.Add(this.LblHari);
            this.Controls.Add(this.LblPemrograman);
            this.Name = "FrmCommonControl2";
            this.Text = "Common Control 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPemrograman;
        private System.Windows.Forms.Label LblHari;
        private System.Windows.Forms.ComboBox CmbPemrograman;
        private System.Windows.Forms.RadioButton RbtSeninRabu;
        private System.Windows.Forms.RadioButton RbtSelasaKamis;
        private System.Windows.Forms.RadioButton RbtSabtuMinggu;
        private System.Windows.Forms.Label LblSkill;
        private System.Windows.Forms.CheckBox ChkMicrosoft;
        private System.Windows.Forms.CheckBox ChkOracle;
        private System.Windows.Forms.CheckBox ChkSun;
        private System.Windows.Forms.CheckBox ChkIBM;
        private System.Windows.Forms.Label LblJam;
        private System.Windows.Forms.ListBox LstJamKursus;
    }
}

