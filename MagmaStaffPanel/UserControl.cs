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
    public partial class UserControl : Form
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
        public static string conString = "";
        public UserControl()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RemovePoints removePoints = new RemovePoints();
            this.Hide();
            removePoints.ShowDialog();
        }
        private void ConnectDB()
        {
            server = "87.121.82.44";
            database = "s3_magmacraft";
            user = "u3_5W42Pp7Wu2";
            password = "ToCWgAQGAy=7zy4zRdLIbQp.";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            connection.Open();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            ConnectDB();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addPoints addPoints = new addPoints();
            this.Hide();
            addPoints.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            checkPoints checkPoints = new checkPoints();
            this.Hide();
            checkPoints.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            CreateMeeting createMeeting = new CreateMeeting();
            this.Hide();
            createMeeting.ShowDialog();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            checkChecks checkChecks = new checkChecks();
            this.Hide();
            checkChecks.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Във разработка ...");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Във разработка ...");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Във разработка ...");
        }
    }
}
