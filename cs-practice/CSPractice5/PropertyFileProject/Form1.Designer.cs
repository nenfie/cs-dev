namespace PropertyFileProject
{
    partial class FrmPropertyFile
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
            this.BtnRetrieveProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRetrieveProperty
            // 
            this.BtnRetrieveProperty.Location = new System.Drawing.Point(56, 12);
            this.BtnRetrieveProperty.Name = "BtnRetrieveProperty";
            this.BtnRetrieveProperty.Size = new System.Drawing.Size(128, 23);
            this.BtnRetrieveProperty.TabIndex = 0;
            this.BtnRetrieveProperty.Text = "Retrieve File Property";
            this.BtnRetrieveProperty.UseVisualStyleBackColor = true;
            this.BtnRetrieveProperty.Click += new System.EventHandler(this.BtnRetrieveProperty_Click);
            // 
            // FrmPropertyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 42);
            this.Controls.Add(this.BtnRetrieveProperty);
            this.Name = "FrmPropertyFile";
            this.Text = "Property File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRetrieveProperty;
    }
}

