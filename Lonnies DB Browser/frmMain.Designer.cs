namespace Lonnies_DB_Browser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.dATABASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJetAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdJetDatabase = new System.Windows.Forms.OpenFileDialog();
            this.txtConnection = new System.Windows.Forms.Label();
            this.chkJet = new System.Windows.Forms.CheckBox();
            this.chkMySQL = new System.Windows.Forms.CheckBox();
            this.chkSQLite = new System.Windows.Forms.CheckBox();
            this.ofdSQLiteDatabase = new System.Windows.Forms.OpenFileDialog();
            this.openMSSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMsSQLServer = new System.Windows.Forms.CheckBox();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATABASEToolStripMenuItem,
            this.qUERYToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(424, 28);
            this.msMain.TabIndex = 32;
            this.msMain.Text = "msMain";
            // 
            // dATABASEToolStripMenuItem
            // 
            this.dATABASEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJetAccessToolStripMenuItem,
            this.openSQLiteToolStripMenuItem,
            this.openMySQLToolStripMenuItem,
            this.openMSSQLServerToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.dATABASEToolStripMenuItem.Name = "dATABASEToolStripMenuItem";
            this.dATABASEToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.dATABASEToolStripMenuItem.Text = "DATABASE";
            // 
            // openJetAccessToolStripMenuItem
            // 
            this.openJetAccessToolStripMenuItem.Name = "openJetAccessToolStripMenuItem";
            this.openJetAccessToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.openJetAccessToolStripMenuItem.Text = "Open Jet/Access";
            this.openJetAccessToolStripMenuItem.Click += new System.EventHandler(this.openJetAccessToolStripMenuItem_Click);
            // 
            // openSQLiteToolStripMenuItem
            // 
            this.openSQLiteToolStripMenuItem.Name = "openSQLiteToolStripMenuItem";
            this.openSQLiteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.openSQLiteToolStripMenuItem.Text = "Open SQLite";
            this.openSQLiteToolStripMenuItem.Click += new System.EventHandler(this.openSQLiteToolStripMenuItem_Click);
            // 
            // openMySQLToolStripMenuItem
            // 
            this.openMySQLToolStripMenuItem.Name = "openMySQLToolStripMenuItem";
            this.openMySQLToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.openMySQLToolStripMenuItem.Text = "Open MySQL";
            this.openMySQLToolStripMenuItem.Click += new System.EventHandler(this.openMySQLToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // qUERYToolStripMenuItem
            // 
            this.qUERYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQueryToolStripMenuItem,
            this.showTablesToolStripMenuItem,
            this.findColumnsToolStripMenuItem});
            this.qUERYToolStripMenuItem.Enabled = false;
            this.qUERYToolStripMenuItem.Name = "qUERYToolStripMenuItem";
            this.qUERYToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.qUERYToolStripMenuItem.Text = "QUERY";
            // 
            // createQueryToolStripMenuItem
            // 
            this.createQueryToolStripMenuItem.Name = "createQueryToolStripMenuItem";
            this.createQueryToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.createQueryToolStripMenuItem.Text = "Create Query...";
            this.createQueryToolStripMenuItem.Click += new System.EventHandler(this.createQueryToolStripMenuItem_Click);
            // 
            // showTablesToolStripMenuItem
            // 
            this.showTablesToolStripMenuItem.Name = "showTablesToolStripMenuItem";
            this.showTablesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.showTablesToolStripMenuItem.Text = "Show Tables";
            this.showTablesToolStripMenuItem.Click += new System.EventHandler(this.showTablesToolStripMenuItem_Click);
            // 
            // findColumnsToolStripMenuItem
            // 
            this.findColumnsToolStripMenuItem.Name = "findColumnsToolStripMenuItem";
            this.findColumnsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.findColumnsToolStripMenuItem.Text = "Find Columns...";
            this.findColumnsToolStripMenuItem.Click += new System.EventHandler(this.findColumnsToolStripMenuItem_Click);
            // 
            // ofdJetDatabase
            // 
            this.ofdJetDatabase.FileName = "openFileDialog1";
            this.ofdJetDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdDatabase_FileOk);
            // 
            // txtConnection
            // 
            this.txtConnection.AutoSize = true;
            this.txtConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.Location = new System.Drawing.Point(16, 118);
            this.txtConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(101, 17);
            this.txtConnection.TabIndex = 33;
            this.txtConnection.Text = "No Connection";
            // 
            // chkJet
            // 
            this.chkJet.AutoSize = true;
            this.chkJet.Enabled = false;
            this.chkJet.Location = new System.Drawing.Point(17, 46);
            this.chkJet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkJet.Name = "chkJet";
            this.chkJet.Size = new System.Drawing.Size(49, 21);
            this.chkJet.TabIndex = 34;
            this.chkJet.Text = "Jet";
            this.chkJet.UseVisualStyleBackColor = true;
            // 
            // chkMySQL
            // 
            this.chkMySQL.AutoSize = true;
            this.chkMySQL.Enabled = false;
            this.chkMySQL.Location = new System.Drawing.Point(164, 46);
            this.chkMySQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMySQL.Name = "chkMySQL";
            this.chkMySQL.Size = new System.Drawing.Size(76, 21);
            this.chkMySQL.TabIndex = 35;
            this.chkMySQL.Text = "MySQL";
            this.chkMySQL.UseVisualStyleBackColor = true;
            // 
            // chkSQLite
            // 
            this.chkSQLite.AutoSize = true;
            this.chkSQLite.Enabled = false;
            this.chkSQLite.Location = new System.Drawing.Point(79, 46);
            this.chkSQLite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSQLite.Name = "chkSQLite";
            this.chkSQLite.Size = new System.Drawing.Size(73, 21);
            this.chkSQLite.TabIndex = 36;
            this.chkSQLite.Text = "SQLite";
            this.chkSQLite.UseVisualStyleBackColor = true;
            // 
            // ofdSQLiteDatabase
            // 
            this.ofdSQLiteDatabase.FileName = "openFileDialog1";
            this.ofdSQLiteDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSQLiteDatabase_FileOk);
            // 
            // openMSSQLServerToolStripMenuItem
            // 
            this.openMSSQLServerToolStripMenuItem.Name = "openMSSQLServerToolStripMenuItem";
            this.openMSSQLServerToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.openMSSQLServerToolStripMenuItem.Text = "Open MS SQL Server";
            this.openMSSQLServerToolStripMenuItem.Click += new System.EventHandler(this.openMSSQLServerToolStripMenuItem_Click);
            // 
            // chkMsSQLServer
            // 
            this.chkMsSQLServer.AutoSize = true;
            this.chkMsSQLServer.Enabled = false;
            this.chkMsSQLServer.Location = new System.Drawing.Point(248, 46);
            this.chkMsSQLServer.Margin = new System.Windows.Forms.Padding(4);
            this.chkMsSQLServer.Name = "chkMsSQLServer";
            this.chkMsSQLServer.Size = new System.Drawing.Size(104, 21);
            this.chkMsSQLServer.TabIndex = 37;
            this.chkMsSQLServer.Text = "SQL Server";
            this.chkMsSQLServer.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 166);
            this.Controls.Add(this.chkMsSQLServer);
            this.Controls.Add(this.chkSQLite);
            this.Controls.Add(this.chkMySQL);
            this.Controls.Add(this.chkJet);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Lonnie\'s DB Browser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem dATABASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJetAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUERYToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdJetDatabase;
        private System.Windows.Forms.ToolStripMenuItem createQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findColumnsToolStripMenuItem;
        private System.Windows.Forms.Label txtConnection;
        private System.Windows.Forms.CheckBox chkJet;
        private System.Windows.Forms.CheckBox chkMySQL;
        private System.Windows.Forms.ToolStripMenuItem openSQLiteToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkSQLite;
        private System.Windows.Forms.OpenFileDialog ofdSQLiteDatabase;
        private System.Windows.Forms.ToolStripMenuItem openMSSQLServerToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkMsSQLServer;
    }
}

