namespace LoadTextFileProject
{
    partial class FrmLoadTextFile
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
            this.LblPath = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.TxtLoadData = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(12, 9);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(29, 13);
            this.LblPath.TabIndex = 0;
            this.LblPath.Text = "Path";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(47, 9);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(192, 20);
            this.TxtPath.TabIndex = 1;
            // 
            // TxtLoadData
            // 
            this.TxtLoadData.Location = new System.Drawing.Point(7, 35);
            this.TxtLoadData.Multiline = true;
            this.TxtLoadData.Name = "TxtLoadData";
            this.TxtLoadData.Size = new System.Drawing.Size(232, 131);
            this.TxtLoadData.TabIndex = 2;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(7, 177);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(99, 23);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Load Text File";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmLoadTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 212);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.TxtLoadData);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.LblPath);
            this.Name = "FrmLoadTextFile";
            this.Text = "Load Text File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.TextBox TxtLoadData;
        private System.Windows.Forms.Button BtnLoad;
    }
}

