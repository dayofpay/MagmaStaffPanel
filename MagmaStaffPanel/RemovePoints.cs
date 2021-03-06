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
    public partial class RemovePoints : Form
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
        public RemovePoints()
        {
            InitializeComponent();
            server = "vashiqt_serv";
            database = "vashiqt_serv";
            user = "vashiqt_serv";
            password = "vashiqt_serv";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var converttoint = int.Parse(pointBox.Text);
            var inval = Convert.ToInt32(converttoint);
            MySqlCommand command = new MySqlCommand("UPDATE currentpoints SET points = points - " + "'" + inval + "'" + "WHERE staff = " + "'" + userBox.Text + "'" + ";", connection);
            MySqlCommand command2 = new MySqlCommand("INSERT INTO removedpoints(staff,date_removed,remove_reason,removed_by) VALUES(" + "'" + userBox.Text + "'" +"," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + reasonBox.Text + "'" + "," + "'" + API.GetUsername + "'" + ")" + ";", connection);
            statusBox.Text = "Успешно премахнахте " + pointBox.Text + " точки на " + userBox.Text + " с причина " + reasonBox.Text + " ! ";
            command.ExecuteScalar();
            command2.ExecuteScalar();
        }

        private void RemovePoints_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
    }
}
