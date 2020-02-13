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
    public partial class frmMySQLSettings : Form
    {
        MySQLConnection mc;
        frmMain main;

        public frmMySQLSettings(frmMain _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void btnConnect_Click(object sender, EventArgs e) { Proceed(); }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { Proceed(); } }

        private void Proceed()
        {
            mc = new MySQLConnection(txtUserName.Text, txtPassword.Text, txtServer.Text, txtDBName.Text, txtPort.Text);

            try { mc.OpenConnection(); }
            catch (Exception ex) { MessageBox.Show("Database Connection Failed\n" + ex.ToString()); return; }
            main.MySQLConnected(mc);
            this.Close();    
        }
    }
}
