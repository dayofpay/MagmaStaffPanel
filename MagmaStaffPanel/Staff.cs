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
    public partial class Staff : Form
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
        public Staff()
        {
            InitializeComponent();
            server = "localhost";
            database = "magmastaff";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
        }
        public static string conString = "";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                Logs logs = new Logs();
                this.Hide();
                logs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                Points points = new Points();
                this.Hide();
                points.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                Requests requests = new Requests();
                this.Hide();
                requests.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                StaffMeetings staffMeetings = new StaffMeetings();
                this.Hide();
                staffMeetings.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                MoreCheck moreCheck = new MoreCheck();
                this.Hide();
                moreCheck.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вече сте в това меню");
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            connection.Open();
            using (MySqlCommand cmd2 = new MySqlCommand
("SELECT username,role FROM users" + ";", connection))
            {
                using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        listBox1.Items.Add(reader2[0]);
                        listBox2.Items.Add(reader2[1]);
                    }
                    reader2.Close();
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
