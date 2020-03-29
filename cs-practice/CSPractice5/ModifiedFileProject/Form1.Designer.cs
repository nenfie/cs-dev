namespace ModifiedFileProject
{
    partial class FrmModifiedFile
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
            this.LblSource = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.TxtDestination = new System.Windows.Forms.TextBox();
            this.GrpAction = new System.Windows.Forms.GroupBox();
            this.BtnCopyFile = new System.Windows.Forms.Button();
            this.BtnMovingFile = new System.Windows.Forms.Button();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.GrpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(12, 9);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(41, 13);
            this.LblSource.TabIndex = 0;
            this.LblSource.Text = "Source";
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Location = new System.Drawing.Point(12, 33);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(60, 13);
            this.LblDestination.TabIndex = 1;
            this.LblDestination.Text = "Destination";
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(83, 6);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(183, 20);
            this.TxtSource.TabIndex = 2;
            // 
            // TxtDestination
            // 
            this.TxtDestination.Location = new System.Drawing.Point(83, 30);
            this.TxtDestination.Name = "TxtDestination";
            this.TxtDestination.Size = new System.Drawing.Size(183, 20);
            this.TxtDestination.TabIndex = 3;
            // 
            // GrpAction
            // 
            this.GrpAction.Controls.Add(this.BtnDeleteFile);
            this.GrpAction.Controls.Add(this.BtnMovingFile);
            this.GrpAction.Controls.Add(this.BtnCopyFile);
            this.GrpAction.Location = new System.Drawing.Point(15, 70);
            this.GrpAction.Name = "GrpAction";
            this.GrpAction.Size = new System.Drawing.Size(251, 130);
            this.GrpAction.TabIndex = 4;
            this.GrpAction.TabStop = false;
            this.GrpAction.Text = "Action";
            // 
            // BtnCopyFile
            // 
            this.BtnCopyFile.Location = new System.Drawing.Point(24, 19);
            this.BtnCopyFile.Name = "BtnCopyFile";
            this.BtnCopyFile.Size = new System.Drawing.Size(75, 23);
            this.BtnCopyFile.TabIndex = 1;
            this.BtnCopyFile.Text = "Copy File";
            this.BtnCopyFile.UseVisualStyleBackColor = true;
            this.BtnCopyFile.Click += new System.EventHandler(this.BtnCopyFile_Click);
            // 
            // BtnMovingFile
            // 
            this.BtnMovingFile.Location = new System.Drawing.Point(24, 48);
            this.BtnMovingFile.Name = "BtnMovingFile";
            this.BtnMovingFile.Size = new System.Drawing.Size(75, 23);
            this.BtnMovingFile.TabIndex = 2;
            this.BtnMovingFile.Text = "Moving File";
            this.BtnMovingFile.UseVisualStyleBackColor = true;
            this.BtnMovingFile.Click += new System.EventHandler(this.BtnMovingFile_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.Location = new System.Drawing.Point(24, 77);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteFile.TabIndex = 3;
            this.BtnDeleteFile.Text = "Delete File";
            this.BtnDeleteFile.UseVisualStyleBackColor = true;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // FrmModifiedFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.GrpAction);
            this.Controls.Add(this.TxtDestination);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.LblSource);
            this.Name = "FrmModifiedFile";
            this.Text = "Modified File";
            this.GrpAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.TextBox TxtDestination;
        private System.Windows.Forms.GroupBox GrpAction;
        private System.Windows.Forms.Button BtnDeleteFile;
        private System.Windows.Forms.Button BtnMovingFile;
        private System.Windows.Forms.Button BtnCopyFile;
    }
}

