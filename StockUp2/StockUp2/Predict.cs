using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockUp2
{
    public partial class Predict : Form
    {
        public string UserName = "";
        public string PassWord = "";
        public Predict()
        {
            InitializeComponent();

        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            txtUserName.Text = UserName;
            txtPassWord.Text = PassWord;
        }
    }
}
