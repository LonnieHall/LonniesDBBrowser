using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lonnies_DB_Browser
{
    public partial class frmJetSettings : Form
    {        
        frmMain main;

        public frmJetSettings(frmMain _main, string path)
        {
            InitializeComponent();
            txtDatabasePath.Text = path;
            main = _main;
        }

        private void Proceed()
        {
            var jc = new JetConnection(txtDatabasePath.Text, txtPassword.Text, txtProvider.Text);
            try { jc.OpenConnection(); }
            catch (Exception ex) { MessageBox.Show("Database Connection Failed\n" + ex.ToString()); return; }
            main.JetConnected(jc);
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e) { Proceed(); }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { Proceed(); } }
    }
}
