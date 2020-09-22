namespace PointCardManagementSystem_Group4
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.button1 = new System.Windows.Forms.Button();
            this.labPlayer = new System.Windows.Forms.Label();
            this.lblCardStatus = new System.Windows.Forms.Label();
            this.btnlCardStatus = new System.Windows.Forms.Button();
            this.lblCreate = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTopup = new System.Windows.Forms.Label();
            this.btnTopup = new System.Windows.Forms.Button();
            this.lblProblem = new System.Windows.Forms.Label();
            this.btnProblem = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // labPlayer
            // 
            resources.ApplyResources(this.labPlayer, "labPlayer");
            this.labPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.labPlayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.labPlayer.ForeColor = System.Drawing.Color.Red;
            this.labPlayer.Name = "labPlayer";
            this.labPlayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCardStatus
            // 
            resources.ApplyResources(this.lblCardStatus, "lblCardStatus");
            this.lblCardStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblCardStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCardStatus.Name = "lblCardStatus";
            // 
            // btnlCardStatus
            // 
            this.btnlCardStatus.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.btnlCardStatus, "btnlCardStatus");
            this.btnlCardStatus.Name = "btnlCardStatus";
            this.btnlCardStatus.UseVisualStyleBackColor = false;
            this.btnlCardStatus.MouseLeave += new System.EventHandler(this.btnlCardStatus_MouseLeave);
            this.btnlCardStatus.MouseHover += new System.EventHandler(this.btnlCardStatus_MouseHover);
            // 
            // lblCreate
            // 
            resources.ApplyResources(this.lblCreate, "lblCreate");
            this.lblCreate.BackColor = System.Drawing.SystemColors.Control;
            this.lblCreate.ForeColor = System.Drawing.Color.Red;
            this.lblCreate.Name = "lblCreate";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            this.btnCreate.MouseHover += new System.EventHandler(this.btnCreate_MouseHover);
            // 
            // lblTopup
            // 
            resources.ApplyResources(this.lblTopup, "lblTopup");
            this.lblTopup.BackColor = System.Drawing.SystemColors.Control;
            this.lblTopup.ForeColor = System.Drawing.Color.Red;
            this.lblTopup.Name = "lblTopup";
            // 
            // btnTopup
            // 
            this.btnTopup.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.btnTopup, "btnTopup");
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.UseVisualStyleBackColor = false;
            this.btnTopup.MouseLeave += new System.EventHandler(this.btnTopup_MouseLeave);
            this.btnTopup.MouseHover += new System.EventHandler(this.btnTopup_MouseHover);
            // 
            // lblProblem
            // 
            resources.ApplyResources(this.lblProblem, "lblProblem");
            this.lblProblem.BackColor = System.Drawing.SystemColors.Control;
            this.lblProblem.ForeColor = System.Drawing.Color.Red;
            this.lblProblem.Name = "lblProblem";
            // 
            // btnProblem
            // 
            this.btnProblem.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.btnProblem, "btnProblem");
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.UseVisualStyleBackColor = false;
            this.btnProblem.MouseLeave += new System.EventHandler(this.btnProblem_MouseLeave);
            this.btnProblem.MouseHover += new System.EventHandler(this.btnProblem_MouseHover);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // Staff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.btnProblem);
            this.Controls.Add(this.lblTopup);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCardStatus);
            this.Controls.Add(this.btnlCardStatus);
            this.Controls.Add(this.labPlayer);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseHover += new System.EventHandler(this.Staff_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labPlayer;
        private System.Windows.Forms.Label lblCardStatus;
        private System.Windows.Forms.Button btnlCardStatus;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTopup;
        private System.Windows.Forms.Button btnTopup;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Button btnProblem;
        private System.Windows.Forms.Label lblWelcome;
    }
}