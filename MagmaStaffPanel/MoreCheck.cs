using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MagmaStaffPanel
{
    public partial class MoreCheck : Form
    {
        MySqlConnection con = new MySqlConnection(DefaultUI.conString);
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        public MoreCheck()
        {

            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            API.checkStatus = "startCheck";
            Checks checks = new Checks();
            this.Hide();
            checks.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Checks checks = new Checks();
            this.Hide();
            checks.ShowDialog();
        }
    }
}
