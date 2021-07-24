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
    public partial class StaffMeetings : Form
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
        public StaffMeetings()
        {
            InitializeComponent();
            connection = new MySqlConnection(conString);
            server = "localhost";
            database = "magmastaff";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            connection.Open();
            using (MySqlCommand cmd4 = new MySqlCommand
("SELECT meeting_hour FROM meetings", connection))
            {
                using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                {
                    while (reader4.Read())
                    {
                        date_hour = reader4.GetString(0);
                    }
                    reader4.Close();
                }
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

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (DefaultUI.log_status == "true")
            {

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
            if (DefaultUI.log_status == "true" && DefaultUI.logrole == "owner")
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
        public static string date_hour = "";
        private void StaffMeetings_Load(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand
       ("SELECT meeting_id FROM meetings", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader[0]);
                    }
                    reader.Close();
                    using (MySqlCommand cmd2 = new MySqlCommand
       ("SELECT meeting_topic FROM meetings", connection))
                    {
                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                listBox2.Items.Add(reader2.GetString(0));
                            }
                            reader2.Close();
                        }
                    }
                    using (MySqlCommand cmd3 = new MySqlCommand
("SELECT meeting_date FROM meetings", connection))
                    {
                        using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                        {
                            while (reader3.Read())
                            {
                                listBox3.Items.Add(reader3[0] + "/" + date_hour);
                            }
                            reader3.Close();
                        }
                    }
                    using (MySqlCommand cmd4 = new MySqlCommand
       ("SELECT meet_status FROM meetings_status WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                    {
                        using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                        {
                            while (reader4.Read())
                            {
                                listBox4.Items.Add(reader4[0]);
                            }
                            reader4.Close();
                            // NULL EXPRESION: [1337] ++ [7777] // ^_^
                        }
                    }
                }
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
