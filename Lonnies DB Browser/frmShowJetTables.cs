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
    public partial class frmShowJetTables : Form
    {
        JetConnection jc;
        DataTable dt;

        public frmShowJetTables(JetConnection _jc)
        {
            InitializeComponent();
            jc = _jc;
            dt = jc.Connection.GetSchema("Tables");
            dgvResults.DataSource = dt;
            for (int i = 0; i < dt.Columns.Count; i++ ) 
            {
                var c = dgvResults.Columns[i];
                c.Visible = false;
                if (c.Name == "TABLE_NAME") { c.Visible = true;}
                if (c.Name == "TABLE_TYPE") { c.Visible = true;}
                if (c.Name == "DATE_CREATED") { c.Visible = true;}
                if (c.Name == "DATE_MODIFIED") { c.Visible = true;}                
            }
        }
    }
}
