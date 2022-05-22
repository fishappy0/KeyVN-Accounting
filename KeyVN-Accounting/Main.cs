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

namespace KeyVN_Accounting
{
    public partial class product_id_txtbox : Form
    {
        public product_id_txtbox()
        {
            InitializeComponent();
            DataTable dt = dB.getDT("SELECT * FROM Items");
            dataGridView1.DataSource = dt;
        }
        private dbAccess dB = new dbAccess();
        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = this.Text.Replace("{username}", globals.staff_username);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            notification_lbl.Text = notification_lbl.Text.Replace("{date}", DateTime.Now.ToString("dd/MM/yyyy"));
            notification_lbl.Text = notification_lbl.Text.Replace("{name}", globals.staff_username);
            DataTable dt = dB.getDT("SELECT * FROM Orders");

            int order_count = 0;
            foreach (DataRow row in dt.Rows)
            {
                string valueOfOrderStatus = row[2].ToString();
                if (valueOfOrderStatus != null && valueOfOrderStatus.Equals("Pending"))
                {
                    order_count++;
                }
            }
            notification_lbl.Text = notification_lbl.Text.Replace("{number}", order_count.ToString());
            this.updateTotal();
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
            Application.Exit();
        }

        private void contactInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Support phone number: +84 08001508 \nSupport email: Tech_support@company.com");
        }

        // private void button2_Click(object sender, EventArgs e)
        // {
        //     this.Hide();
        //     detailed_view dv = new detailed_view();
        //     dv.FormClosed += (send, eventArgs) => this.Close();
        //     dv.ShowDialog();
        // }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            orders order_form = new orders();
            order_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.staff_userid = "DBG001";
            globals.staff_username = "debug_user1234";
            this.Hide();
            Login login_form = new Login();
            login_form.FormClosed += (send, eventArgs) => this.Close();
            login_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM Items WHERE ItemID=@ItemID OR ItemName like @ItemName";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@ItemID", productid_txtbox.Text);
            parameters.Add("@ItemName", "%" + product_name_txtbox.Text + "%");
            DataTable dt = dB.getDT(sqlStr, parameters);
            dataGridView1.DataSource = dt;
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_management acm_form = new Account_management();
            acm_form.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            history his_form = new history();
            his_form.ShowDialog();
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history his_form = new history();
            his_form.ShowDialog();
        }

        private void importFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orders or_form = new orders();
            or_form.ShowDialog();
        }
        private void updateTotal()
        {
            float money_amount = 0;
            float quantity = 0;
            int order_count = 0;
            DataTable dt = dB.getDT("SELECT * FROM Orders");
            //Console.WriteLine(dataGridView1.Rows[0].Cells[7].Value);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var valueOfMoneyCell = row.Cells[7].Value;
                var totalQuantity = row.Cells[5].Value;
                if (valueOfMoneyCell != null && float.TryParse(valueOfMoneyCell.ToString(), out _))
                {
                    money_amount += float.Parse(valueOfMoneyCell.ToString());
                }
                if (totalQuantity != null && float.TryParse(totalQuantity.ToString(), out _))
                {
                    quantity += float.Parse(totalQuantity.ToString());
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                string valueOfOrderStatus = row[2].ToString();
                if (valueOfOrderStatus != null && valueOfOrderStatus.Equals("Delivering"))
                {
                    order_count++;
                }
            }
            estimated_profit_lbl.Text = money_amount.ToString("#,#") + " " + "VND";
            quantity_lbl.Text = quantity.ToString();
            order_delivery_lbl.Text = order_count.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.updateTotal();
        }

        private void findAndReplaceText(wordProcessing WP)
        {
            Dictionary<String, String> find_and_replace_dict = new Dictionary<String, String>();
            find_and_replace_dict.Add("{year}", DateTime.Now.Year.ToString());
            find_and_replace_dict.Add("{month}", DateTime.Now.Month.ToString());
            find_and_replace_dict.Add("{date}", DateTime.Now.Day.ToString());
            find_and_replace_dict.Add("{courierName}", "");
            find_and_replace_dict.Add("{storageName}", "");
            find_and_replace_dict.Add("{storageLocation}", "");
            find_and_replace_dict.Add("{totalAmountText}", "");
            find_and_replace_dict.Add("{totalAmount}", "");
            find_and_replace_dict.Add("{officialDocuments}", "");

            WP.replaceWords(find_and_replace_dict);
        }
        private void openSaveDialog(string form_name, Action<String> func)
        {
            saveFileDialog1.Filter = "Word 2015 Documents File (*.docx)|*.doc";
            saveFileDialog1.FileName = form_name + ".docx";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.InitialDirectory = @"%USERPROFILE%\Desktop";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                func(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancelled the save action");
            }
        }
        private void importFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openSaveDialog("import_form", fileLocation =>
             {
                 wordProcessing WP = new wordProcessing();
                 WP.setWordDocWithAddress(AppDomain.CurrentDomain.BaseDirectory + @"\documentTemplates\import_form.doc");
                 findAndReplaceText(WP);
                 WP.saveInstance(fileLocation);
                 WP.printWordDoc();
                 WP = null;
                 MessageBox.Show("Operation executed successfully!");
             });
        }

        private void exportFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openSaveDialog("export_form", fileLocation =>
             {
                 wordProcessing WP = new wordProcessing();
                 WP.setWordDocWithAddress(AppDomain.CurrentDomain.BaseDirectory + @"\documentTemplates\export_form.doc");
                 findAndReplaceText(WP);
                 WP.saveInstance(fileLocation);
                 WP.printWordDoc();
                 WP = null;
                 MessageBox.Show("Operation executed successfully!");
             });

        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = dB.getDT("SELECT * FROM Items");
            dataGridView1.DataSource = dt;
        }
    }
}
