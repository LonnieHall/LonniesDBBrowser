using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Lonnies_DB_Browser
{
    public partial class frmMain : Form
    {
        public JetConnection jc;
        public MySQLConnection mc;
        public SQLiteConn lc;
        public MsSQLServerConnection msc;

        public frmMain() { InitializeComponent(); }

        public void JetConnected(JetConnection _jc)
        { 
            jc = _jc; chkJet.Checked = true;
            showTablesToolStripMenuItem.Enabled = true;
            findColumnsToolStripMenuItem.Enabled = false;
            GUIUpdateConnected(jc.DatabasePath); 
        }

        public void MySQLConnected(MySQLConnection _mc)
        { 
            mc = _mc; chkMySQL.Checked = true; 
            showTablesToolStripMenuItem.Enabled = true;
            findColumnsToolStripMenuItem.Enabled = true;
            GUIUpdateConnected(mc.Host); 
        }

        public void MsSQLServerConnected(MsSQLServerConnection _msc)
        {
            msc = _msc; chkMsSQLServer.Checked = true;
            showTablesToolStripMenuItem.Enabled = true;
            findColumnsToolStripMenuItem.Enabled = true;
            GUIUpdateConnected(msc.Host); 
        }

        public void SQLiteConnected(SQLiteConn _lc)
        {
            lc = _lc; chkSQLite.Checked = true;
            showTablesToolStripMenuItem.Enabled = true;
            findColumnsToolStripMenuItem.Enabled = false;
            GUIUpdateConnected(lc.DatabasePath);
        }

        public void GUIUpdateConnected(string connectedTo)
        {
            dATABASEToolStripMenuItem.BackColor = Color.Green;
            disconnectToolStripMenuItem.Enabled = true;
            qUERYToolStripMenuItem.Enabled = true;
            txtConnection.Text = "Connected to: " + Environment.NewLine + connectedTo;
        }

        private void openJetAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdJetDatabase.Title = "Please select the JET database.";
            ofdJetDatabase.InitialDirectory = @"C:\";
            ofdJetDatabase.FileName = "";
            ofdJetDatabase.Filter = "JET Database|*.mdb|All Files|*.*";
            ofdJetDatabase.ShowDialog();
        }

        private void ofdDatabase_FileOk(object sender, CancelEventArgs e)
        {
            var jetSettings = new frmJetSettings(this, ofdJetDatabase.FileName);
            jetSettings.Show();
        }

        private void createQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewQuery nq = null;
            if (mc != null) { nq = new frmNewQuery(mc); }
            else if (msc != null) { nq = new frmNewQuery(msc); }
            else if (jc != null) { nq = new frmNewQuery(jc); }
            else if (lc != null) { nq = new frmNewQuery(lc); }
            nq.Show();
        }
        
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disconnect();            
            txtConnection.Text = "No Connection";
            dATABASEToolStripMenuItem.BackColor = default(Color);
            disconnectToolStripMenuItem.Enabled = false;
            qUERYToolStripMenuItem.Enabled = false;
            chkJet.Checked = false;
            chkMySQL.Checked = false;
            chkSQLite.Checked = false;
            chkMsSQLServer.Checked = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) { disconnect(); }

        private void disconnect()
        {
            try { jc.CloseConnection(); }
            catch (Exception) { }

            try { mc.CloseConnection(); }
            catch (Exception) { }

            try { lc.CloseConnection(); }
            catch (Exception) { }

            try { msc.CloseConnection(); }
            catch (Exception) { }

            jc = null; mc = null; lc = null; msc = null;
        }

        private void openMySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMySQLSettings mysqlSettings = new frmMySQLSettings(this);
            mysqlSettings.Show();
        }

        private void showTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mc != null) 
            {
                try
                {
                    frmQueryResults qr = new frmQueryResults(mc, "Show Tables;");
                    qr.Show();
                }
                catch (Exception) { }
            }
            else if (jc != null)
            {
                try { frmShowJetTables sjt = new frmShowJetTables(jc); sjt.Show(); }
                catch (Exception) {}
            }
            else if (lc != null)
            {                
                try
                {
                    frmQueryResults qr = new frmQueryResults(lc, "SELECT NAME from sqlite_master;");
                    qr.Show();
                }
                catch (Exception) { }
            }

        }

        private void findColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mc != null)
            {
                try
                {
                    frmFindColumns fc = new frmFindColumns(mc);
                    fc.Show();
                }
                catch (Exception) { }
            }
            else { }              
        }

        private void openSQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdSQLiteDatabase.Title = "Please select the SQLite database.";
            ofdSQLiteDatabase.InitialDirectory = @"C:\";
            ofdSQLiteDatabase.FileName = "";
            ofdSQLiteDatabase.Filter = "All Files|*.*";
            ofdSQLiteDatabase.ShowDialog();
        }

        private void ofdSQLiteDatabase_FileOk(object sender, CancelEventArgs e)
        {
            var sqlitesettings = new frmSQLiteSettings(this, ofdSQLiteDatabase.FileName);
            sqlitesettings.Show();
        }

        private void openMSSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MsSQLServerSettings = new frmMSSQLServerSettings(this);
            MsSQLServerSettings.Show();
        }
    }
}
