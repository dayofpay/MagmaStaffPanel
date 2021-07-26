using System;
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
    public partial class CreateMeeting : Form
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
        public CreateMeeting()
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

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
        public static int getId = 0;
        private void continueButton_Click(object sender, EventArgs e)
        {
            var converttoint = int.Parse(hour1.Text);
            var inval = Convert.ToInt32(converttoint);
            var converttoint2 = int.Parse(hour2.Text);
            var inval2 = Convert.ToInt32(converttoint2);
            statusLabel.Visible = true;
            statusLabel.Text = "Успешно!";
            Random random = new Random();
            var selectId = random.Next(5, 35);
            getId = selectId;
            using (MySqlCommand cmd3 = new MySqlCommand
("INSERT INTO meetings(meeting_id,meeting_topic,meeting_date,meeting_hour) VALUES('" + getId + "'" + "," + "'" + povod.Text + "'" + "," + "'" + dateTimepick.Text +"'" + "," + "'" + inval + ":" + inval2 + "'" + ")", connection))
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

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
