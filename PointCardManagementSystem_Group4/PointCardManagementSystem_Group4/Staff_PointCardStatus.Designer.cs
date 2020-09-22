namespace PointCardManagementSystem_Group4
{
    partial class Staff_PointCardStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_PointCardStatus));
            this.pointCardDatabaseDataSet = new PointCardManagementSystem_Group4.PointCardDatabaseDataSet();
            this.pointCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointCardTableAdapter = new PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.PointCardTableAdapter();
            this.tableAdapterManager = new PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.TableAdapterManager();
            this.pointCardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pointCardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pointCardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTopup = new System.Windows.Forms.Button();
            this.btnProblem = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCardStatus = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardBindingNavigator)).BeginInit();
            this.pointCardBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointCardDatabaseDataSet
            // 
            this.pointCardDatabaseDataSet.DataSetName = "PointCardDatabaseDataSet";
            this.pointCardDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointCardBindingSource
            // 
            this.pointCardBindingSource.DataMember = "PointCard";
            this.pointCardBindingSource.DataSource = this.pointCardDatabaseDataSet;
            // 
            // pointCardTableAdapter
            // 
            this.pointCardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FeedbackTableAdapter = null;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.Player_StaffTableAdapter = null;
            this.tableAdapterManager.PointCardTableAdapter = this.pointCardTableAdapter;
            this.tableAdapterManager.UpdateOrder = PointCardManagementSystem_Group4.PointCardDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorldTableAdapter = null;
            this.tableAdapterManager.ZombieTableAdapter = null;
            // 
            // pointCardBindingNavigator
            // 
            this.pointCardBindingNavigator.AddNewItem = null;
            this.pointCardBindingNavigator.BindingSource = this.pointCardBindingSource;
            this.pointCardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pointCardBindingNavigator.DeleteItem = null;
            this.pointCardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.pointCardBindingNavigatorSaveItem});
            this.pointCardBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.pointCardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pointCardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pointCardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pointCardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pointCardBindingNavigator.Name = "pointCardBindingNavigator";
            this.pointCardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pointCardBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.pointCardBindingNavigator.TabIndex = 0;
            this.pointCardBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pointCardBindingNavigatorSaveItem
            // 
            this.pointCardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pointCardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pointCardBindingNavigatorSaveItem.Image")));
            this.pointCardBindingNavigatorSaveItem.Name = "pointCardBindingNavigatorSaveItem";
            this.pointCardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pointCardBindingNavigatorSaveItem.Text = "Save Data";
            this.pointCardBindingNavigatorSaveItem.Click += new System.EventHandler(this.pointCardBindingNavigatorSaveItem_Click_1);
            // 
            // pointCardDataGridView
            // 
            this.pointCardDataGridView.AutoGenerateColumns = false;
            this.pointCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointCardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pointCardDataGridView.DataSource = this.pointCardBindingSource;
            this.pointCardDataGridView.Location = new System.Drawing.Point(270, 69);
            this.pointCardDataGridView.Name = "pointCardDataGridView";
            this.pointCardDataGridView.Size = new System.Drawing.Size(450, 395);
            this.pointCardDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CardID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CardID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Activecode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Activecode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Creator";
            this.dataGridViewTextBoxColumn4.HeaderText = "Creator";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(48, 20);
            this.menu1.Text = "Close";
            this.menu1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTopup);
            this.panel1.Controls.Add(this.btnProblem);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCardStatus);
            this.panel1.Controls.Add(this.btnPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 420);
            this.panel1.TabIndex = 3;
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
            this.btnTopup.TabIndex = 22;
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
            this.btnProblem.TabIndex = 20;
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
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create Point Card";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(0, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnCardStatus.TabIndex = 18;
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
            this.btnPlayer.TabIndex = 17;
            this.btnPlayer.Text = "Manage Player Account/Top up";
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // Staff_PointCardStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pointCardDataGridView);
            this.Controls.Add(this.pointCardBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Staff_PointCardStatus";
            this.Text = "Staff_PointCardStatus";
            this.Load += new System.EventHandler(this.Staff_PointCardStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardBindingNavigator)).EndInit();
            this.pointCardBindingNavigator.ResumeLayout(false);
            this.pointCardBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointCardDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PointCardDatabaseDataSet pointCardDatabaseDataSet;
        private System.Windows.Forms.BindingSource pointCardBindingSource;
        private PointCardDatabaseDataSetTableAdapters.PointCardTableAdapter pointCardTableAdapter;
        private PointCardDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pointCardBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pointCardBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pointCardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCardStatus;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnTopup;
    }
}