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
    public partial class addPoints : Form
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
        public addPoints()
        {
            InitializeComponent();
            server = "87.121.82.37";
            database = "s500_magmacraft";
            user = "u500_E3lmPout6J";
            password = "6!+pFAoS0ZEi89upi9TIMPCO";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void AddPoints_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            var converttoint = int.Parse(pointBox.Text);
            var inval = Convert.ToInt32(converttoint);
            MySqlCommand command = new MySqlCommand("UPDATE currentpoints SET points = points + " + "'" + inval + "'" + "WHERE staff = " + "'" + userBox.Text + "'" + ";", connection);
            statusBox.Text = "Успешно добавихте " + pointBox.Text + " точки на " + userBox.Text + " с причина " + reasonBox.Text + " ! ";
            command.ExecuteScalar();
        }

        private void addPoints_Load_1(object sender, EventArgs e)
        {

        }
    }
}
