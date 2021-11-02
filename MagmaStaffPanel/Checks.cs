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
    public partial class Checks : Form
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
        public Checks()
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
        public static string conString = "";
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            MoreCheck moreCheck = new MoreCheck();
            moreCheck.ShowDialog();
        }

        private void startCheckbutton_Click(object sender, EventArgs e)
        {
            API.currentChecked = enduserBox.Text;
            API.startedCheckTime = DateTime.Now.ToString();
            MessageBox.Show("Проверката на " + userBox.Text + " започна !");
            using (MySqlCommand cmd4 = new MySqlCommand
("INSERT INTO checks(checkuser,checked_by,check_status,check_start_time,check_end_time) VALUES" + "(" + "'" + userBox.Text + "'" + "," + "'" + API.GetUsername + "'" + "," + "'" + "Проверява се ..." + "'" + "," + "'" + DateTime.Now.ToString() + "'" + "," + "'" + "NULL" + "'" + ")", connection))
            {
                using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                {
                    while (reader4.Read())
                    {
                    }
                    reader4.Close();
                }
            }
        }

        private void Checks_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notFound_CheckedChanged(object sender, EventArgs e)
        {
            if (found.Checked == true)
            {
                comment.Visible = true;
                comment.Text = "Име на хака/хаковете:";
                conclusionText.Visible = true;
                API.checkConclusion = "true";
            }
        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {
            if (other.Checked == true)
            {
                comment.Visible = true;
                comment.Text = "Коментар:";
                API.checkConclusion = "true";
                conclusionText.Visible = true;
            }
        }

        private void found_CheckedChanged(object sender, EventArgs e)
        {
            if (found.Checked == true)
            {
                conclusionText.Visible = true;
                API.checkConclusion = "true";
            }
        }

        private void endUserButton_Click(object sender, EventArgs e)
        {
            API.currentChecked = enduserBox.Text;
            if (API.checkConclusion == "true")
            {
                if (notFound.Checked == true)
                {
                    using (MySqlCommand cmd4 = new MySqlCommand
("INSERT INTO checks(checkuser,checked_by,check_status,check_start_time,check_end_time) VALUES" + "(" + "'" + API.currentChecked + "'" + "," + "'" + API.GetUsername + "'" + "," + "'" + "Чист" + "'" + "," + "'" + API.startedCheckTime + "'" + "," + "'" + DateTime.Now.ToString() + "'" + ")", connection))
                    {
                        using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                        {
                            while (reader4.Read())
                            {
                            }
                            reader4.Close();
                        }
                        MessageBox.Show(API.currentChecked + " е отбелчзан като ЧИСТ");
                    }
                }
                if (found.Checked == true)
                {
                    using (MySqlCommand cmd4 = new MySqlCommand
("INSERT INTO checks(checkuser,checked_by,check_status,check_start_time,check_end_time) VALUES" + "(" + "'" + API.currentChecked + "'" + "," + "'" + API.GetUsername + "'" + "," + "'" + "Открит хак (" + conclusionText.Text + ")" + "'" + "," + "'" + API.startedCheckTime + "'" + "," + "'" + DateTime.Now.ToString() + "'" + ")", connection))
                    {
                        using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                        {
                            while (reader4.Read())
                            {
                            }
                            reader4.Close();
                        }
                        MessageBox.Show(API.currentChecked + " е отбелчзан като ОТКРИТ(" + conclusionText.Text + ")");
                    }
                }
            }
            else
            {
                MessageBox.Show("Моля изберете поне един аргумент");
            }
        }

        private void notFound_CheckedChanged_1(object sender, EventArgs e)
        {
            if (notFound.Checked == true)
            {
                API.checkConclusion = "true";
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.ShowDialog();
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startCheck_Click(object sender, EventArgs e)
        {

        }

        private void endCheck_Click(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void enduserLabel_Click(object sender, EventArgs e)
        {

        }

        private void enduserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conclusion_Click(object sender, EventArgs e)
        {

        }

        private void conclusionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void comment_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            playersHistory playersHistory = new playersHistory();
            this.Hide();
            playersHistory.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            pinRequire pin = new pinRequire();
            this.Hide();
            pin.ShowDialog();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }
    }
}
