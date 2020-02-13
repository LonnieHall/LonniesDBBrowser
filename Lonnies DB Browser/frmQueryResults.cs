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
    public partial class frmQueryResults : Form
    {
        DatabaseConnection dc;
        string qry;
        DataTable dt;

        public frmQueryResults(DatabaseConnection _dc, string _qry)
        {
            InitializeComponent();
            try { dc = _dc; qry = _qry; }
            catch (DataException de) { MessageBox.Show("Data Exception\n" + qry + "\n" + de.ToString()); this.Close(); }
            catch (Exception ex) { MessageBox.Show("Query Failed\n" + qry + "\n" + ex.ToString()); this.Close(); }              
            try 
            {
                dt = dc.SqlSelectTable(qry);
                dgvResults.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dgvResults.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Query Failed\n" + qry + "\n" + ex.ToString()); this.Close(); }            
        }
    }
}
