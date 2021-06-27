﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
namespace MagmaStaffPanel
{
    public partial class DefaultUI : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        public DefaultUI()
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
        private Form ActiveForm;
        private int tempIndex;
        public static string checkLogsInfo = "";
        public static string conString = "";
        private Button currentButton;
        public static string logged_username = "";
        public static string log_status = "";
        public static string totalmutes = "";
        public static string totalPoints = "";
        public static string log_date = "";
        public static string log_date_hour_format = "";
        public static string totalbans = "";
        public static string logrole = "";
        private Random random;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void conexion()
        {
            try
            {
                if (log_status == "true")
                {
                    connection.Open();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand
                               ("SELECT points,bans,mutes FROM totalbans WHERE user = " + "'" + logged_username + "'" + ";", connection))
                        {
                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    totalbans = reader.GetString(1);
                                    totalPoints = reader.GetString(0);
                                    totalmutes = reader.GetString(2);
                                }

                                if (reader.NextResult())
                                {
                                    while (reader.Read())
                                    {
                                        MessageBox.Show(reader.GetString(0), "Table2.Column2");
                                    }
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Вие не сте вписан !");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }
        public static string list = "s";
        private void checkLogs()
        {
            try
            {
                if (log_status == "true")
                {
                    connection.Open();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand
                               ("SELECT log_type,log_date,log_time FROM logs WHERE staff = " + "'" + logged_username + "'" + ";", connection))
                        {
                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    checkLogsInfo = reader.GetString(0);
                                    log_date = reader.GetString(1);
                                    log_date_hour_format = reader.GetString(2);
                                }

                                if (reader.NextResult())
                                {
                                    while (reader.Read())
                                    {
                                        checkLogsInfo = reader.GetString(1);
                                        log_date = reader.GetString(2);
                                        log_date_hour_format = reader.GetString(3);
                                    }
                                }
                            }
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Вие не сте вписан !");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conexion();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (log_status == "true")
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
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void OpenChildForm(Form Logs, object btnsender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
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

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
        }
        public static string gettyoe = "";
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "dayofpay" && guna2TextBox2.Text == "dayofpay")
            {
                connection.Open();
                logrole = "owner";
                log_status = "true";
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Успешен Вход," + guna2TextBox1.Text;
                logged_username = guna2TextBox1.Text;
                label5.Text = totalbans.ToString();
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + logged_username + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "SUCCESS" + "'" + ")", connection))
                {

                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }

            }
            else if (guna2TextBox1.Text == "admin" && guna2TextBox2.Text == "admin")
            {
                connection.Open();
                logged_username = guna2TextBox1.Text;
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + logged_username + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "SUCCESS" + "'" + ")", connection))
                {

                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }
                logrole = "owner";
                log_status = "true";
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Успешен Вход," + guna2TextBox1.Text;
                label5.Text = totalbans.ToString();
            }
            else if (guna2TextBox1.Text == "demo" && guna2TextBox2.Text == "demo")
            {
                logged_username = guna2TextBox1.Text;
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + logged_username + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "SUCCESS" + "'" + ")", connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }
                logrole = "demo";
                log_status = "true";
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Успешен Вход," + guna2TextBox1.Text;
                label5.Text = totalbans.ToString();
            }
            else if (guna2TextBox1.Text == "tisho_bg" && guna2TextBox2.Text == "baluk")
            {
                logged_username = guna2TextBox1.Text;
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + logged_username + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "SUCCESS" + "'" + ")", connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }
                logrole = "admin";
                log_status = "true";
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Успешен Вход," + guna2TextBox1.Text;
                label5.Text = totalbans.ToString();
            }
            else if (guna2TextBox1.Text == "galactic22" && guna2TextBox2.Text == "baubau")
            {
                connection.Open();
                logged_username = guna2TextBox1.Text;
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + logged_username + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "SUCCESS" + "'" + ")", connection))
                {

                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }
                logrole = "owner";
                log_status = "true";
                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Успешен Вход," + guna2TextBox1.Text;

                label5.Text = totalbans.ToString();
            }
            else
            {
                connection.Open();
                WebRequest request = WebRequest.Create("https://api.my-ip.io/ip");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                log_status = "false";
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Неправилен Username / или парола !";
                using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO program_logs(login_username,login_ip,login_password,login_date,login_status) VALUES" + "(" + "'" + guna2TextBox1.Text + "'" + "," + "'" + responseFromServer + "'" + "," + "'" + guna2TextBox2.Text + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "FAIL" + "'" + ")", connection))
                {

                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                        }
                        reader3.Close();
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            StaffMeetings staffMeetings = new StaffMeetings();
            this.Hide();
            staffMeetings.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
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
            if (log_status == "true")
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
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (log_status == "true")
            {

            }
            else
            {
                MessageBox.Show("Вие не сте вписан !");
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
//                 connection.Open();
               // using (MySqlConnection connection = new MySqlConnection(connectionString))
               // {
                 //   using (MySqlCommand command = new MySqlCommand
                         //  ("INSERT INTO totalbans(user,bans,mutes,points) VALUES('denteck',0,0,1);", connection))
                  //  {
                     //   connection.Open();
                      //  using (MySqlDataReader reader2 = command.ExecuteReader())
                      //  {
                       //     while (reader2.Read())
                        //    {
                         //       MessageBox.Show(reader2.GetString(0), "Table1.Column1");
                        ///    }
                       // }
                  // }
              //  }
