using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RegradeProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=192.168.1.1;port=3306;username=root;password=blaze23104289`;database=programn";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            MySqlCommand command = new MySqlCommand("SELECT * FROM accounts WHERE username= " + tbUsername.Text + "AND password=" + tbPassword.Text + ";");

            MySqlDataReader myReader;
            myConn.Open();
            myReader = command.ExecuteReader();

        }
    }
}
