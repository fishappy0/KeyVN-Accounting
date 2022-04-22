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
        public Login()
        {
            InitializeComponent();
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
            Main form = new Main();
            form.ShowDialog();
        }
    }
}
