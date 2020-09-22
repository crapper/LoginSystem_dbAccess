namespace PointCardManagementSystem_Group4
{
    partial class gamesNews
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
            System.Windows.Forms.Label gameIDLabel;
            System.Windows.Forms.Label launchDateLabel;
            System.Windows.Forms.Label gamenameLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamesNews));
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCardDatabaseDataSet = new PointCardManagementSystem_Group4.PointCardDatabaseDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.GameTableAdapter();
            this.tableAdapterManager = new PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.TableAdapterManager();
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.txtLaunchDate = new System.Windows.Forms.TextBox();
            this.txtGamename = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            gameIDLabel = new System.Windows.Forms.Label();
            launchDateLabel = new System.Windows.Forms.Label();
            gamenameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gameIDLabel
            // 
            gameIDLabel.AutoSize = true;
            gameIDLabel.BackColor = System.Drawing.Color.Transparent;
            gameIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gameIDLabel.Location = new System.Drawing.Point(36, 86);
            gameIDLabel.Name = "gameIDLabel";
            gameIDLabel.Size = new System.Drawing.Size(64, 16);
            gameIDLabel.TabIndex = 5;
            gameIDLabel.Text = "Game ID:";
            // 
            // launchDateLabel
            // 
            launchDateLabel.AutoSize = true;
            launchDateLabel.BackColor = System.Drawing.Color.Transparent;
            launchDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            launchDateLabel.Location = new System.Drawing.Point(36, 120);
            launchDateLabel.Name = "launchDateLabel";
            launchDateLabel.Size = new System.Drawing.Size(86, 16);
            launchDateLabel.TabIndex = 7;
            launchDateLabel.Text = "Launch Date:";
            // 
            // gamenameLabel
            // 
            gamenameLabel.AutoSize = true;
            gamenameLabel.BackColor = System.Drawing.Color.Transparent;
            gamenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gamenameLabel.Location = new System.Drawing.Point(36, 153);
            gamenameLabel.Name = "gamenameLabel";
            gamenameLabel.Size = new System.Drawing.Size(82, 16);
            gamenameLabel.TabIndex = 9;
            gamenameLabel.Text = "Gamename:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = System.Drawing.Color.Transparent;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            typeLabel.Location = new System.Drawing.Point(36, 183);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(43, 16);
            typeLabel.TabIndex = 11;
            typeLabel.Text = "Type:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(36, 265);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Game ID :";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 259);
            this.txtID.MaxLength = 1;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(199, 259);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 31);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(50, 20);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pointCardDatabaseDataSet
            // 
            this.pointCardDatabaseDataSet.DataSetName = "PointCardDatabaseDataSet";
            this.pointCardDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.pointCardDatabaseDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FeedbackTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter;
            this.tableAdapterManager.Player_StaffTableAdapter = null;
            this.tableAdapterManager.PointCardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorldTableAdapter = null;
            this.tableAdapterManager.ZombieTableAdapter = null;
            // 
            // txtGameID
            // 
            this.txtGameID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "GameID", true));
            this.txtGameID.Location = new System.Drawing.Point(124, 80);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.ReadOnly = true;
            this.txtGameID.Size = new System.Drawing.Size(100, 22);
            this.txtGameID.TabIndex = 6;
            // 
            // txtLaunchDate
            // 
            this.txtLaunchDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "LaunchDate", true));
            this.txtLaunchDate.Location = new System.Drawing.Point(124, 114);
            this.txtLaunchDate.Name = "txtLaunchDate";
            this.txtLaunchDate.ReadOnly = true;
            this.txtLaunchDate.Size = new System.Drawing.Size(100, 22);
            this.txtLaunchDate.TabIndex = 8;
            // 
            // txtGamename
            // 
            this.txtGamename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Gamename", true));
            this.txtGamename.Location = new System.Drawing.Point(124, 147);
            this.txtGamename.Name = "txtGamename";
            this.txtGamename.ReadOnly = true;
            this.txtGamename.Size = new System.Drawing.Size(100, 22);
            this.txtGamename.TabIndex = 10;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "Type", true));
            this.txtType.Location = new System.Drawing.Point(124, 175);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 12;
            // 
            // gamesNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(326, 316);
            this.Controls.Add(gameIDLabel);
            this.Controls.Add(this.txtGameID);
            this.Controls.Add(launchDateLabel);
            this.Controls.Add(this.txtLaunchDate);
            this.Controls.Add(gamenameLabel);
            this.Controls.Add(this.txtGamename);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gamesNews";
            this.Text = "Games News";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private PointCardDatabaseDataSet pointCardDatabaseDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private PointCardDatabaseDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private PointCardDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtGameID;
        private System.Windows.Forms.TextBox txtLaunchDate;
        private System.Windows.Forms.TextBox txtGamename;
        private System.Windows.Forms.TextBox txtType;
    }
}