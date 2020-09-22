namespace PointCardManagementSystem_Group4
{
    partial class Player_Topup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Topup));
            this.label1 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.btnPointToVirtual = new System.Windows.Forms.Button();
            this.btnTopup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEnquire = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblService.Location = new System.Drawing.Point(216, 60);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(569, 42);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "Please Select Service You Need:";
            // 
            // btnPointToVirtual
            // 
            this.btnPointToVirtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(192)))));
            this.btnPointToVirtual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPointToVirtual.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnPointToVirtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPointToVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointToVirtual.Location = new System.Drawing.Point(373, 183);
            this.btnPointToVirtual.Name = "btnPointToVirtual";
            this.btnPointToVirtual.Size = new System.Drawing.Size(237, 51);
            this.btnPointToVirtual.TabIndex = 3;
            this.btnPointToVirtual.Text = "Convert Point To Virtual Money";
            this.btnPointToVirtual.UseVisualStyleBackColor = false;
            this.btnPointToVirtual.Click += new System.EventHandler(this.btnPointToVirtual_Click);
            // 
            // btnTopup
            // 
            this.btnTopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(114)))));
            this.btnTopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopup.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnTopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopup.Location = new System.Drawing.Point(373, 310);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(237, 51);
            this.btnTopup.TabIndex = 4;
            this.btnTopup.Text = "Top-up Point By Point Card";
            this.btnTopup.UseVisualStyleBackColor = false;
            this.btnTopup.Click += new System.EventHandler(this.btnTopup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(51, 20);
            this.menu1.Text = "Close";
            this.menu1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLaunch);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQA);
            this.panel1.Controls.Add(this.btnGame);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnEnquire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 384);
            this.panel1.TabIndex = 6;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaunch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaunch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLaunch.Location = new System.Drawing.Point(0, 260);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(131, 65);
            this.btnLaunch.TabIndex = 33;
            this.btnLaunch.Text = "Launch Game";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(0, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 65);
            this.button1.TabIndex = 32;
            this.button1.Text = "Top Up Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQA
            // 
            this.btnQA.BackColor = System.Drawing.Color.Transparent;
            this.btnQA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQA.FlatAppearance.BorderSize = 0;
            this.btnQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQA.Location = new System.Drawing.Point(0, 130);
            this.btnQA.Name = "btnQA";
            this.btnQA.Size = new System.Drawing.Size(131, 65);
            this.btnQA.TabIndex = 30;
            this.btnQA.Text = "Reflect Problem";
            this.btnQA.UseVisualStyleBackColor = false;
            this.btnQA.Click += new System.EventHandler(this.btnQA_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGame.Location = new System.Drawing.Point(0, 65);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(131, 65);
            this.btnGame.TabIndex = 31;
            this.btnGame.Text = "Play \'Guess The Number\'";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(0, 319);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 65);
            this.btnLogout.TabIndex = 34;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEnquire
            // 
            this.btnEnquire.BackColor = System.Drawing.Color.Transparent;
            this.btnEnquire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnquire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnquire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnquire.FlatAppearance.BorderSize = 0;
            this.btnEnquire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnquire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnquire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnquire.Location = new System.Drawing.Point(0, 0);
            this.btnEnquire.Name = "btnEnquire";
            this.btnEnquire.Size = new System.Drawing.Size(131, 65);
            this.btnEnquire.TabIndex = 29;
            this.btnEnquire.Text = "Enquire Account / Games Details";
            this.btnEnquire.UseVisualStyleBackColor = false;
            this.btnEnquire.Click += new System.EventHandler(this.btnEnquire_Click);
            // 
            // Player_Topup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.btnPointToVirtual);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player_Topup";
            this.Text = "Player_Topup";
            this.Load += new System.EventHandler(this.Player_Topup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Button btnPointToVirtual;
        private System.Windows.Forms.Button btnTopup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEnquire;
    }
}