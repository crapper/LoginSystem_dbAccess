namespace PointCardManagementSystem_Group4
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // labTitle
            // 
            resources.ApplyResources(this.labTitle, "labTitle");
            this.labTitle.Name = "labTitle";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2,
            this.menu3});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1_1,
            this.Menu1_2,
            this.Menu1_3,
            this.Menu1_4});
            this.menu1.Name = "menu1";
            resources.ApplyResources(this.menu1, "menu1");
            // 
            // Menu1_1
            // 
            this.Menu1_1.Name = "Menu1_1";
            resources.ApplyResources(this.Menu1_1, "Menu1_1");
            this.Menu1_1.Click += new System.EventHandler(this.sdaToolStripMenuItem_Click);
            // 
            // Menu1_2
            // 
            this.Menu1_2.Name = "Menu1_2";
            resources.ApplyResources(this.Menu1_2, "Menu1_2");
            // 
            // Menu1_3
            // 
            this.Menu1_3.Name = "Menu1_3";
            resources.ApplyResources(this.Menu1_3, "Menu1_3");
            // 
            // Menu1_4
            // 
            this.Menu1_4.Name = "Menu1_4";
            resources.ApplyResources(this.Menu1_4, "Menu1_4");
            // 
            // menu2
            // 
            this.menu2.Name = "menu2";
            resources.ApplyResources(this.menu2, "menu2");
            // 
            // menu3
            // 
            this.menu3.Name = "menu3";
            resources.ApplyResources(this.menu3, "menu3");
            // 
            // btnForget
            // 
            resources.ApplyResources(this.btnForget, "btnForget");
            this.btnForget.Name = "btnForget";
            this.btnForget.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            resources.ApplyResources(this.btnRegistration, "btnRegistration");
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem Menu1_1;
        private System.Windows.Forms.ToolStripMenuItem Menu1_2;
        private System.Windows.Forms.ToolStripMenuItem Menu1_3;
        private System.Windows.Forms.ToolStripMenuItem Menu1_4;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem menu3;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Button btnRegistration;
    }
}

