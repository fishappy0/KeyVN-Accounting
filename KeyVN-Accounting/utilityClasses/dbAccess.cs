using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace KeyVN_Accounting
{
    internal class dbAccess
    {
        private SqlConnection conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["connString"].ConnectionString)
        );
        private String QUERY = "";

        public dbAccess(String QUERY = "SELECT * FROM Employee")
        {
            this.QUERY = QUERY;
            try
            {
                this.conn.Open();
            }

            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        public void setQuery(String QUERY)
        {
            this.QUERY = QUERY;
        }

        public System.Data.DataTable getDT(String QUERY = "SELECT * FROM Employee")
        {
            this.QUERY = QUERY;
            System.Data.DataTable DT = new System.Data.DataTable();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open) conn.Open();
                System.Data.SqlClient.SqlCommand login = new SqlCommand(QUERY, this.conn);
                System.Data.SqlClient.SqlDataAdapter DA = new SqlDataAdapter(login);
                DA.Fill(DT);
                conn.Close();
                return DT;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                return DT;
            }
        }

    }
}
