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
    public partial class Requests : Form
    {
        MySqlConnection con = new MySqlConnection(DefaultUI.conString);
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        public static string conString = "";
        public Requests()
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            connection.Open();
            using (MySqlCommand cmd = new MySqlCommand
       ("SELECT message_content FROM messagerequests WHERE to_user = " + "'" + API.GetUsername + "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox2.Items.Add(reader[0]);
                    }
                    reader.Close();
                    using (MySqlCommand cmd2 = new MySqlCommand
("SELECT message_send_date FROM messagerequests WHERE to_user = " + "'" + API.GetUsername + "'" + ";", connection))
                    {
                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                listBox1.Items.Add(reader2[0].ToString());
                            }
                            reader2.Close();
                        }
                    }
                    using (MySqlCommand cmd3 = new MySqlCommand
("SELECT from_user FROM messagerequests WHERE to_user = " + "'" + API.GetUsername + "'" + ";", connection))
                    {
                        using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                        {
                            while (reader3.Read())
                            {
                                listBox4.Items.Add(reader3[0].ToString());
                            }
                            reader3.Close();
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO messagerequests(from_user,to_user,message_content,message_send_date) VALUES" + "(" + "'" + API.GetUsername + "'" + "," + "'" + guna2TextBox3.Text + "'" + "," + "'" + guna2TextBox2.Text +"'" + "," + "'" + DateTime.Now.ToString() +"'" + ")", connection))
            {
                using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                    }
                    reader3.Close();
                }
            }
            MessageBox.Show("Успешно ");
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                playersHistory playersHistory = new playersHistory();
                this.Hide();
                playersHistory.ShowDialog();
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

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                Staff staff = new Staff();
                this.Hide();
                staff.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {
                pinRequire pin = new pinRequire();
                this.Hide();
                pin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {

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
    }
}
