namespace MenuToolbarProject
{
    partial class FrmMenuToolbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuToolbar));
            this.MnMenu = new System.Windows.Forms.MenuStrip();
            this.MnProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMicrosoftProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MnOracleProject = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenu = new System.Windows.Forms.ToolStrip();
            this.TsMicrosoftProject = new System.Windows.Forms.ToolStripButton();
            this.TsOracleProject = new System.Windows.Forms.ToolStripButton();
            this.MnMenu.SuspendLayout();
            this.TsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnMenu
            // 
            this.MnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnProject});
            this.MnMenu.Location = new System.Drawing.Point(0, 0);
            this.MnMenu.Name = "MnMenu";
            this.MnMenu.Size = new System.Drawing.Size(309, 24);
            this.MnMenu.TabIndex = 0;
            this.MnMenu.Text = "menuStrip1";
            // 
            // MnProject
            // 
            this.MnProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnMicrosoftProject,
            this.MnOracleProject});
            this.MnProject.Name = "MnProject";
            this.MnProject.Size = new System.Drawing.Size(56, 20);
            this.MnProject.Text = "Project";
            // 
            // MnMicrosoftProject
            // 
            this.MnMicrosoftProject.Name = "MnMicrosoftProject";
            this.MnMicrosoftProject.Size = new System.Drawing.Size(165, 22);
            this.MnMicrosoftProject.Text = "Microsoft Project";
            // 
            // MnOracleProject
            // 
            this.MnOracleProject.Name = "MnOracleProject";
            this.MnOracleProject.Size = new System.Drawing.Size(165, 22);
            this.MnOracleProject.Text = "Oracle Project";
            // 
            // TsMenu
            // 
            this.TsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMicrosoftProject,
            this.TsOracleProject});
            this.TsMenu.Location = new System.Drawing.Point(0, 24);
            this.TsMenu.Name = "TsMenu";
            this.TsMenu.Size = new System.Drawing.Size(309, 25);
            this.TsMenu.TabIndex = 1;
            this.TsMenu.Text = "toolStrip1";
            // 
            // TsMicrosoftProject
            // 
            this.TsMicrosoftProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsMicrosoftProject.Image = ((System.Drawing.Image)(resources.GetObject("TsMicrosoftProject.Image")));
            this.TsMicrosoftProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsMicrosoftProject.Name = "TsMicrosoftProject";
            this.TsMicrosoftProject.Size = new System.Drawing.Size(23, 22);
            this.TsMicrosoftProject.Text = "toolStripButton1";
            // 
            // TsOracleProject
            // 
            this.TsOracleProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsOracleProject.Image = ((System.Drawing.Image)(resources.GetObject("TsOracleProject.Image")));
            this.TsOracleProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsOracleProject.Name = "TsOracleProject";
            this.TsOracleProject.Size = new System.Drawing.Size(23, 22);
            this.TsOracleProject.Text = "toolStripButton1";
            // 
            // FrmMenuToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 247);
            this.Controls.Add(this.TsMenu);
            this.Controls.Add(this.MnMenu);
            this.MainMenuStrip = this.MnMenu;
            this.Name = "FrmMenuToolbar";
            this.Text = "Menu Toolbar";
            this.MnMenu.ResumeLayout(false);
            this.MnMenu.PerformLayout();
            this.TsMenu.ResumeLayout(false);
            this.TsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnMenu;
        private System.Windows.Forms.ToolStripMenuItem MnProject;
        private System.Windows.Forms.ToolStripMenuItem MnMicrosoftProject;
        private System.Windows.Forms.ToolStripMenuItem MnOracleProject;
        private System.Windows.Forms.ToolStrip TsMenu;
        private System.Windows.Forms.ToolStripButton TsMicrosoftProject;
        private System.Windows.Forms.ToolStripButton TsOracleProject;
    }
}

