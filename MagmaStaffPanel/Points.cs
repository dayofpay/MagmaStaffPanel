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
    public partial class Points : Form
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
        public static string totalpoints = "0";
        public Points()
        {
            InitializeComponent();
        }

        private void Points_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(API.GetUsername);
            connection = new MySqlConnection(DefaultUI.conString);
            connection.Open();
            using (MySqlCommand cmd = new MySqlCommand
       ("SELECT points FROM currentpoints WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        label25.Text = "Вие в момента имате " + reader.GetString(0) + " Точки !";
                    }
                    reader.Close();
                    using (MySqlCommand cmd2 = new MySqlCommand
("SELECT date_removed FROM removedpoints WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                    {
                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                listBox2.Items.Add(reader2[0]);
                            }
                            reader2.Close();
                        }
                        using (MySqlCommand cmd3 = new MySqlCommand
("SELECT remove_reason FROM removedpoints WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                        {
                            using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                            {
                                while (reader3.Read())
                                {
                                    listBox3.Items.Add(reader3[0]);
                                }
                                reader3.Close();
                            }
                        }
                        using (MySqlCommand cmd4 = new MySqlCommand
("SELECT removed_by FROM removedpoints WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                        {
                            using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                            {
                                while (reader4.Read())
                                {
                                    listBox4.Items.Add(reader4[0]);
                                }
                                reader4.Close();
                            }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (DefaultUI.log_status == "true")
            {

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

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
