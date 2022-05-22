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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }
        dbAccess dB = new dbAccess();
        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.DataSource = dB.getDT("SELECT * FROM Histories");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Import_form im_form = new Import_form();
            im_form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Export_form ex_form = new Export_form();
            ex_form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Support phone number: +84 08001508 \nSupport email: Tech_support@company.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            detailed_view dv = new detailed_view();
            dv.FormClosed += (send, eventArgs) => this.Close();
            dv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
