using System;
using System.Windows.Forms;

namespace Lonnies_DB_Browser
{
    public partial class frmSQLiteSettings : Form
    {
        public frmMain main;

        public frmSQLiteSettings(frmMain _main, string path)
        {
            InitializeComponent();
            txtDatabasePath.Text = path;
            main = _main;
        }

        private void Proceed()
        {
            var lc = new SQLiteConn(txtDatabasePath.Text, txtPassword.Text, txtVersion.Text);
            try { lc.OpenConnection(); }
            catch (Exception ex) { MessageBox.Show("Database Connection Failed\n" + ex.ToString()); return; }
            main.SQLiteConnected(lc);
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e) { Proceed(); }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { Proceed(); } }

    }
}
