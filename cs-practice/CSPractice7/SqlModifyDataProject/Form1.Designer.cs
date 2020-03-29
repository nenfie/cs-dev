namespace SqlModifyDataProject
{
    partial class FrmCreateDivisi
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
            this.LblNameDivisi = new System.Windows.Forms.Label();
            this.LblIdManager = new System.Windows.Forms.Label();
            this.TxtNamaDivisi = new System.Windows.Forms.TextBox();
            this.TxtIdManager = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNameDivisi
            // 
            this.LblNameDivisi.AutoSize = true;
            this.LblNameDivisi.Location = new System.Drawing.Point(12, 9);
            this.LblNameDivisi.Name = "LblNameDivisi";
            this.LblNameDivisi.Size = new System.Drawing.Size(75, 13);
            this.LblNameDivisi.TabIndex = 0;
            this.LblNameDivisi.Text = "Division Name";
            // 
            // LblIdManager
            // 
            this.LblIdManager.AutoSize = true;
            this.LblIdManager.Location = new System.Drawing.Point(12, 37);
            this.LblIdManager.Name = "LblIdManager";
            this.LblIdManager.Size = new System.Drawing.Size(61, 13);
            this.LblIdManager.TabIndex = 1;
            this.LblIdManager.Text = "Id Manager";
            // 
            // TxtNamaDivisi
            // 
            this.TxtNamaDivisi.Location = new System.Drawing.Point(93, 9);
            this.TxtNamaDivisi.Name = "TxtNamaDivisi";
            this.TxtNamaDivisi.Size = new System.Drawing.Size(123, 20);
            this.TxtNamaDivisi.TabIndex = 2;
            // 
            // TxtIdManager
            // 
            this.TxtIdManager.Location = new System.Drawing.Point(93, 34);
            this.TxtIdManager.Name = "TxtIdManager";
            this.TxtIdManager.Size = new System.Drawing.Size(123, 20);
            this.TxtIdManager.TabIndex = 3;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(12, 64);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // FrmCreateDivisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 112);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtIdManager);
            this.Controls.Add(this.TxtNamaDivisi);
            this.Controls.Add(this.LblIdManager);
            this.Controls.Add(this.LblNameDivisi);
            this.Name = "FrmCreateDivisi";
            this.Text = "Create Divisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNameDivisi;
        private System.Windows.Forms.Label LblIdManager;
        private System.Windows.Forms.TextBox TxtNamaDivisi;
        private System.Windows.Forms.TextBox TxtIdManager;
        private System.Windows.Forms.Button BtnInsert;
    }
}

