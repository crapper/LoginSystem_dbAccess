namespace PointCardManagementSystem_Group4
{
    partial class Staff_TopupPlayerAccount
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTopup = new System.Windows.Forms.Button();
            this.btnProblem = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCardStatus = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(496, 231);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(496, 143);
            this.txtNumber.MaxLength = 8;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(187, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPassword.Location = new System.Drawing.Point(265, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(212, 29);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Card Active Code :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNumber.Location = new System.Drawing.Point(293, 135);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(170, 29);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Card Number :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tan;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(557, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Tan;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(336, 311);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 43);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(496, 79);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 20);
            this.txtUsername.TabIndex = 13;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUsername.Location = new System.Drawing.Point(327, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 29);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTopup);
            this.panel1.Controls.Add(this.btnProblem);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnCardStatus);
            this.panel1.Controls.Add(this.btnPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 420);
            this.panel1.TabIndex = 14;
            // 
            // btnTopup
            // 
            this.btnTopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTopup.ForeColor = System.Drawing.Color.Black;
            this.btnTopup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTopup.Location = new System.Drawing.Point(0, 280);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(131, 70);
            this.btnTopup.TabIndex = 15;
            this.btnTopup.Text = "Top up Player Account By Point Card";
            this.btnTopup.UseVisualStyleBackColor = false;
            this.btnTopup.Click += new System.EventHandler(this.btnTopup_Click);
            // 
            // btnProblem
            // 
            this.btnProblem.BackColor = System.Drawing.Color.Transparent;
            this.btnProblem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnProblem.ForeColor = System.Drawing.Color.Black;
            this.btnProblem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProblem.Location = new System.Drawing.Point(0, 210);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(131, 70);
            this.btnProblem.TabIndex = 16;
            this.btnProblem.Text = "View Player Questions";
            this.btnProblem.UseVisualStyleBackColor = false;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreate.Location = new System.Drawing.Point(0, 140);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 70);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create Point Card";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(0, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 70);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCardStatus
            // 
            this.btnCardStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnCardStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCardStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCardStatus.ForeColor = System.Drawing.Color.Black;
            this.btnCardStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCardStatus.Location = new System.Drawing.Point(0, 70);
            this.btnCardStatus.Name = "btnCardStatus";
            this.btnCardStatus.Size = new System.Drawing.Size(131, 70);
            this.btnCardStatus.TabIndex = 13;
            this.btnCardStatus.Text = "Manage Point Card Status";
            this.btnCardStatus.UseVisualStyleBackColor = false;
            this.btnCardStatus.Click += new System.EventHandler(this.btnCardStatus_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlayer.Location = new System.Drawing.Point(0, 0);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(131, 70);
            this.btnPlayer.TabIndex = 12;
            this.btnPlayer.Text = "Manage Player Account";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // Staff_TopupPlayerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Staff_TopupPlayerAccount";
            this.Text = "Staff_TopupPlayerAccount";
            this.Load += new System.EventHandler(this.Staff_TopupPlayerAccount_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTopup;
        private System.Windows.Forms.Button btnProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCardStatus;
        private System.Windows.Forms.Button btnPlayer;
    }
}