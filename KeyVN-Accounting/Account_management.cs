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
    public partial class Account_management : Form
    {
        dbAccess dB = new dbAccess();
        public Account_management()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("@UserID", globals._staff_userid);
            DataTable dt = dB.getDT("SELECT * FROM Accounts, Users WHERE Accounts.UserID=@UserID AND Users.UserID=@UserID", map);

            if (globals._staff_username == "debug_user1234")
            {
                MessageBox.Show("Cannot access this feature as a debug user");
                this.Close();
            }
            else
            {
                var dt_col = dt.Rows[0];
                string restore_fullname = full_name_txtbox.Text = dt_col[5].ToString();
                string restore_address = address_txtbox.Text = dt_col[6].ToString();
                string restore_email = email_txtbox.Text = dt_col[7].ToString();
                dateTimePicker1.Value = DateTime.Parse(dt_col[8].ToString());
                string restore_date = dt_col[8].ToString();

                string restore_username = username_txtbox.Text = dt_col[2].ToString();
                string restore_password = password_txtbox.Text = dt_col[3].ToString();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (password_txtbox.Text == confirm_pass_txtbox.Text)
            {
                string Account_QUERY = "UPDATE Accounts SET AccountName=@AccountName, AccountPassword=@AccountPassword WHERE UserID=@UserID";
                string User_QUERY = "UPDATE Users SET UserFullName=@UserFullName, UserAddress=@UserAddress, " +
                                    "UserEmail=@UserEmail, UserDOB=@UserDOB" +
                                    " WHERE UserID=@UserID";
                Dictionary<string, string> account_query_dict = new Dictionary<string, string>();
                Dictionary<string, string> user_query_dict = new Dictionary<string, string>();

                account_query_dict.Add("@AccountName", username_txtbox.Text);
                account_query_dict.Add("@AccountPassword", password_txtbox.Text);
                account_query_dict.Add("@UserID", globals.staff_userid);

                user_query_dict.Add("@UserFullName", full_name_txtbox.Text);
                user_query_dict.Add("@UserAddress", address_txtbox.Text);
                user_query_dict.Add("@UserEmail", email_txtbox.Text);
                user_query_dict.Add("@UserDOB", dateTimePicker1.Value.ToString());
                user_query_dict.Add("@UserID", globals.staff_userid);

                dB.updateTable(Account_QUERY, account_query_dict);
                dB.updateTable(User_QUERY, user_query_dict);
                MessageBox.Show("Updated successfully!");
            }
            else
            {
                MessageBox.Show("Password and the password in confirmation does not match!");
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
