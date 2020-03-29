namespace SqlStoreProcProject
{
    partial class FrmStoreProc
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
            this.BtnExecuteSP = new System.Windows.Forms.Button();
            this.BtnExecuteSP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExecuteSP
            // 
            this.BtnExecuteSP.Location = new System.Drawing.Point(12, 10);
            this.BtnExecuteSP.Name = "BtnExecuteSP";
            this.BtnExecuteSP.Size = new System.Drawing.Size(75, 23);
            this.BtnExecuteSP.TabIndex = 0;
            this.BtnExecuteSP.Text = "Execute SP";
            this.BtnExecuteSP.UseVisualStyleBackColor = true;
            this.BtnExecuteSP.Click += new System.EventHandler(this.BtnExecuteSP_Click);
            // 
            // BtnExecuteSP2
            // 
            this.BtnExecuteSP2.Location = new System.Drawing.Point(12, 39);
            this.BtnExecuteSP2.Name = "BtnExecuteSP2";
            this.BtnExecuteSP2.Size = new System.Drawing.Size(201, 23);
            this.BtnExecuteSP2.TabIndex = 1;
            this.BtnExecuteSP2.Text = "Execute SP with Parameter";
            this.BtnExecuteSP2.UseVisualStyleBackColor = true;
            this.BtnExecuteSP2.Click += new System.EventHandler(this.BtnExecuteSP2_Click);
            // 
            // FrmStoreProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.BtnExecuteSP2);
            this.Controls.Add(this.BtnExecuteSP);
            this.Name = "FrmStoreProc";
            this.Text = "Execute StoreProc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExecuteSP;
        private System.Windows.Forms.Button BtnExecuteSP2;
    }
}

