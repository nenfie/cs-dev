namespace CreateTextFileProject
{
    partial class FrmCreateTextFile
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
            this.TxtCreate = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCreate
            // 
            this.TxtCreate.Location = new System.Drawing.Point(7, 12);
            this.TxtCreate.Multiline = true;
            this.TxtCreate.Name = "TxtCreate";
            this.TxtCreate.Size = new System.Drawing.Size(315, 185);
            this.TxtCreate.TabIndex = 0;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 203);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create Text File";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FrmCreateTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 237);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtCreate);
            this.Name = "FrmCreateTextFile";
            this.Text = "Create Text File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCreate;
        private System.Windows.Forms.Button BtnCreate;
    }
}

