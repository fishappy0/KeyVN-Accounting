using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyVN_Accounting
{
    public partial class existing_items : Form
    {
        private dbAccess db = new dbAccess();
        public existing_items()
        {
            InitializeComponent();
        }

        private void existing_items_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.DataSource = db.getDT("SELECT * FROM Items");
        }
    }
}
