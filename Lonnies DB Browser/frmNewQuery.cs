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
    public partial class frmNewQuery : Form
    {
        DatabaseConnection dc;

        public frmNewQuery(DatabaseConnection _dc)
        {
            InitializeComponent();
            dc = _dc;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            string qry = txtQRY.Text;
            if (qry.Substring(0, 6).ToUpper() == "SELECT" ||
                qry.Substring(0, 4).ToUpper() == "SHOW") 
            {
                try 
                {
                    frmQueryResults qr = new frmQueryResults(dc, qry);
                    qr.Show();
                }
                catch (Exception) { }
            }

            else 
            { 
                try
                {
                    dc.SqlExecute(qry);
                    MessageBox.Show("Query Execution Complete");
                }
                catch (Exception ex) { MessageBox.Show("Query Failed\n" + qry + "\n" + ex.ToString()); this.Close(); }    
            }
        }

        
    }
}
