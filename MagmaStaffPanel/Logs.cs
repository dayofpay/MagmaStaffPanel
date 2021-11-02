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
    public partial class Logs : Form
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
        public static string moreLogs = "";
        public static string moreLogsDate = "";

        public static string moreLogsDate_Hour_Format = "";
        public Logs()
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            connection.Open();
            using (MySqlCommand cmd = new MySqlCommand
       ("SELECT staff FROM logs WHERE staff = " + "'" + API.GetUsername+ "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(API.GetUsername);
                    }
                    reader.Close();
                    using (MySqlCommand cmd2 = new MySqlCommand
("SELECT log_type FROM logs WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                    {
                        using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                listBox2.Items.Add(reader2[0]);
                            }
                            reader2.Close();
                            using (MySqlCommand cmd3 = new MySqlCommand
        ("SELECT log_date FROM logs WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
                            {
                                using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                                {
                                    while (reader3.Read())
                                    {
                                        listBox3.Items.Add(reader3[0]);
                                    }
                                    reader3.Close();
                                    using (MySqlCommand cmd4 = new MySqlCommand
("SELECT log_time FROM logs WHERE staff = " + "'" + API.GetUsername + "'" + ";", connection))
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
                }
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

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
