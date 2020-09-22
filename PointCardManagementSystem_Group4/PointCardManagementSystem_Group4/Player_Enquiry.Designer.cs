namespace PointCardManagementSystem_Group4
{
    partial class Player_Enquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Enquiry));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnTopup = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEnquire = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(50, 20);
            this.menu1.Text = "Close";
            this.menu1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dvg
            // 
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Location = new System.Drawing.Point(200, 73);
            this.dvg.Name = "dvg";
            this.dvg.Size = new System.Drawing.Size(656, 298);
            this.dvg.TabIndex = 0;
            this.dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLaunch);
            this.panel1.Controls.Add(this.btnTopup);
            this.panel1.Controls.Add(this.btnQA);
            this.panel1.Controls.Add(this.btnGame);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnEnquire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 388);
            this.panel1.TabIndex = 2;
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
            this.btnLaunch.TabIndex = 27;
            this.btnLaunch.Text = "Launch Game";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click_1);
            // 
            // btnTopup
            // 
            this.btnTopup.BackColor = System.Drawing.Color.Transparent;
            this.btnTopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTopup.FlatAppearance.BorderSize = 0;
            this.btnTopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTopup.Location = new System.Drawing.Point(0, 195);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(131, 65);
            this.btnTopup.TabIndex = 26;
            this.btnTopup.Text = "Top Up Account";
            this.btnTopup.UseVisualStyleBackColor = false;
            this.btnTopup.Click += new System.EventHandler(this.btnTopup_Click_1);
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
            this.btnQA.TabIndex = 24;
            this.btnQA.Text = "Reflect Problem";
            this.btnQA.UseVisualStyleBackColor = false;
            this.btnQA.Click += new System.EventHandler(this.btnQA_Click_1);
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
            this.btnGame.TabIndex = 25;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 323);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 65);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
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
            this.btnEnquire.TabIndex = 23;
            this.btnEnquire.Text = "Enquire Account / Games Details";
            this.btnEnquire.UseVisualStyleBackColor = false;
            this.btnEnquire.Click += new System.EventHandler(this.btnEnquire_Click);
            // 
            // Player_Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player_Enquiry";
            this.Text = "Player_Enquiry";
            this.Load += new System.EventHandler(this.Player_Enquiry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnTopup;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEnquire;
    }
}