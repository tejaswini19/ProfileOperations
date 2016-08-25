namespace ProfileOperations
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arithmeticOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosmeticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textKeyEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.arithmeticOperationsToolStripMenuItem,
            this.registrationFormToolStripMenuItem,
            this.cosmeticsToolStripMenuItem,
            this.tickEventToolStripMenuItem,
            this.textKeyEventToolStripMenuItem,
            this.pictureDisplayToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // arithmeticOperationsToolStripMenuItem
            // 
            this.arithmeticOperationsToolStripMenuItem.Name = "arithmeticOperationsToolStripMenuItem";
            this.arithmeticOperationsToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.arithmeticOperationsToolStripMenuItem.Text = "Arithmetic Operations";
            this.arithmeticOperationsToolStripMenuItem.Click += new System.EventHandler(this.arithmeticOperationsToolStripMenuItem_Click);
            // 
            // registrationFormToolStripMenuItem
            // 
            this.registrationFormToolStripMenuItem.Name = "registrationFormToolStripMenuItem";
            this.registrationFormToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.registrationFormToolStripMenuItem.Text = "Registration Form";
            this.registrationFormToolStripMenuItem.Click += new System.EventHandler(this.registrationFormToolStripMenuItem_Click);
            // 
            // cosmeticsToolStripMenuItem
            // 
            this.cosmeticsToolStripMenuItem.Name = "cosmeticsToolStripMenuItem";
            this.cosmeticsToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.cosmeticsToolStripMenuItem.Text = "Cosmetics";
            this.cosmeticsToolStripMenuItem.Click += new System.EventHandler(this.cosmeticsToolStripMenuItem_Click);
            // 
            // tickEventToolStripMenuItem
            // 
            this.tickEventToolStripMenuItem.Name = "tickEventToolStripMenuItem";
            this.tickEventToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.tickEventToolStripMenuItem.Text = "Timer Control";
            this.tickEventToolStripMenuItem.Click += new System.EventHandler(this.tickEventToolStripMenuItem_Click);
            // 
            // textKeyEventToolStripMenuItem
            // 
            this.textKeyEventToolStripMenuItem.Name = "textKeyEventToolStripMenuItem";
            this.textKeyEventToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.textKeyEventToolStripMenuItem.Text = "Text Key Event";
            this.textKeyEventToolStripMenuItem.Click += new System.EventHandler(this.textKeyEventToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pictureDisplayToolStripMenuItem
            // 
            this.pictureDisplayToolStripMenuItem.Name = "pictureDisplayToolStripMenuItem";
            this.pictureDisplayToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.pictureDisplayToolStripMenuItem.Text = "Picture Display";
            this.pictureDisplayToolStripMenuItem.Click += new System.EventHandler(this.pictureDisplayToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arithmeticOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosmeticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textKeyEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureDisplayToolStripMenuItem;
    }
}



