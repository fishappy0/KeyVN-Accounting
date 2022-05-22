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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }
        private dbAccess dB = new dbAccess();
        private string orderid;
        private string accountid;
        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dataGridView1.DataSource = dB.getDT("SELECT * FROM Orders");
            dataGridView2.DataSource = dB.getDT("SELECT * FROM Ordered_items");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Pending")
            {
                try
                {
                    Dictionary<string, string> replace = new Dictionary<string, string>();
                    replace.Add("@order", orderid);
                    dB.updateTable("UPDATE Orders SET OrderStatus = 'Cancelled' WHERE OrderID=@order", replace);
                    dB.updateTable("DELETE FROM Ordered_items WHERE OrderID=@order", replace);
                    MessageBox.Show("Deleted selected order succesfully");
                    dataGridView1.DataSource = dB.getDT("SELECT * FROM Orders");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty selection or order isn't pending");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Pending")
            {
                globals.orderid = orderid;
                globals.accountid = accountid;
                Export_form ex_form = new Export_form();
                ex_form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Empty selection or order isn't pending");
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Pending")
            {
                orderid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                accountid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                Dictionary<string, string> replace = new Dictionary<string, string>();
                replace.Add("@order", orderid);
                dataGridView2.DataSource = dB.getDT("SELECT * FROM Ordered_items WHERE OrderID=@order", replace);
            }
        }
    }
}
