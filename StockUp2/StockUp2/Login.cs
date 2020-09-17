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

namespace StockUp2
{
    public partial class Login : Form
    {
        public bool flagLogin = false;
        public string UserName = "";
        public string PassWord = "";
        const string ConnectionString = "server=103.79.143.121;database=StockUp;persist security info=True;user id=sa;password=Dongchau199@;MultipleActiveResultSets=True; ";

        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                SqlCommand sqlCommand =
                    new SqlCommand("Select * from Account where UserName=@Username and PassWord =@Password", con);
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUser.Text;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPass.Text;


                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    lbSucess.Text = "True";
                    UserName = txtUser.Text;
                    PassWord = txtPass.Text;
                    flagLogin = true;
                    this.Close();
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
