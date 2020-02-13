using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lonnies_DB_Browser
{
    public partial class frmMSSQLServerSettings : Form
    {
        MsSQLServerConnection msc;
        frmMain main;

        public frmMSSQLServerSettings(frmMain _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void btnConnect_Click(object sender, EventArgs e) { Proceed(); }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { Proceed(); } }

        private void Proceed()
        {
            msc = new MsSQLServerConnection(txtUserName.Text, txtPassword.Text, txtServer.Text, txtDBName.Text);

            try { msc.OpenConnection(); }
            catch (Exception ex) { MessageBox.Show("Database Connection Failed\n" + ex.ToString()); return; }
            main.MsSQLServerConnected(msc);
            this.Close();
        }
    }
}
