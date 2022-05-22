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
    public partial class Login : Form
    {
        private dbAccess dB = new dbAccess();
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.AcceptButton = login_btn;
        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                // Draggable top bar
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                //resizable window
                //if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                //{
                //    m.Result = (IntPtr)17;
                //    return;
                //}
            }
            base.WndProc(ref m);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != String.Empty)
            {
                username_txtbox.Text = Properties.Settings.Default.username.ToString();
                password_txtbox.Text = Properties.Settings.Default.password.ToString();
            }
        }

        // Graphical Events, such as changing colors
        // when entering and leaving labels
        private void close_btn_MouseEnter(object sender, EventArgs e)
        {
            close_btn.ForeColor = Color.LightGray;
        }

        private void close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.ForeColor = Color.White;
        }

        private void minimize_btn_MouseEnter(object sender, EventArgs e)
        {
            minimize_btn.ForeColor = Color.LightGray;
        }

        private void minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            product_id_txtbox form = new product_id_txtbox();
            form.FormClosed += (send, event_args) => this.Close();
            form.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM Accounts WHERE AccountName=@AccountName AND AccountPassword=@AccountPassword";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@AccountName", username_txtbox.Text);
            parameters.Add("@AccountPassword", password_txtbox.Text);
            DataTable dt = dB.getDT(sqlStr, parameters);
            if (dt.Rows.Count > 0)
            {
                globals.staff_username = dt.Rows[0][2].ToString();
                globals.staff_userid = dt.Rows[0][0].ToString();
                if (password_chkbox.Checked)
                {
                    Properties.Settings.Default.username = username_txtbox.Text;
                    Properties.Settings.Default.password = password_txtbox.Text;
                    Properties.Settings.Default.Save();
                }
                this.Hide();
                product_id_txtbox form = new product_id_txtbox();
                form.FormClosed += (send, event_args) => this.Close();
                form.ShowDialog();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void recover_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://mail.google.com/mail/?view=cm&source=mailto&to=fishappy0@gmail.com");
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
