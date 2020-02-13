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
    public partial class frmFindColumns : Form
    {
        DatabaseConnection dc;
        public frmFindColumns(DatabaseConnection _dc)
        {
            InitializeComponent();
            dc = _dc;
        }

        private void btnNext_Click(object sender, EventArgs e) { Proceed(); }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { Proceed(); } }

        private void Proceed()
        {
            try
            {
                MySQLConnection mc = (MySQLConnection)dc;
                string qry = "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='" + mc.DatabaseName + "' AND COLUMN_NAME LIKE '%" + txtSearch.Text + "%';";
                frmQueryResults qr = new frmQueryResults(mc, qry);
                qr.Show();
            }
            catch (Exception) { }
        }
    }
}
