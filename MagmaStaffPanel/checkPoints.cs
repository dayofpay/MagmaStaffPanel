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
    public partial class checkPoints : Form
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
        public checkPoints()
        {
            InitializeComponent();
            server = "87.121.82.44";
            database = "s3_magmacraft";
            user = "u3_5W42Pp7Wu2";
            password = "ToCWgAQGAy=7zy4zRdLIbQp.";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);

        }
        public static string checkUser = "";
        private void continueButton_Click(object sender, EventArgs e)
        {
            removedBylabel.Visible = true;
            staffLabel.Visible = true;
            removedBylabel.Visible = true;
            removeReasonlabel.Visible = true;
            removeDateLabel.Visible = true;
            checkUser = userBox.Text;
            staff.Visible = true;
            date_removed.Visible = true;
            remove_reason.Visible = true;
            removed_by.Visible = true;
            using (MySqlCommand cmd = new MySqlCommand
       ("SELECT points FROM currentpoints WHERE staff = " + "'" + userBox.Text + "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        status.Text = userBox.Text + " има " + reader[0].ToString() + " Точки !";
                    }
                    reader.Close();
                }
            }
            using (MySqlCommand cmd = new MySqlCommand
("SELECT staff FROM removedpoints WHERE staff = " + "'" + userBox.Text + "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staff.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
            }
            using (MySqlCommand cmd = new MySqlCommand
("SELECT date_removed FROM removedpoints WHERE staff = " + "'" + userBox.Text + "'" + ";", connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        date_removed.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                }
                using (MySqlCommand cmd2 = new MySqlCommand
("SELECT remove_reason FROM removedpoints WHERE staff = " + "'" + userBox.Text + "'" + ";", connection))
                {
                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            remove_reason.Items.Add(reader[0].ToString());
                        }
                        reader.Close();
                    }
                }
                using (MySqlCommand cmd3 = new MySqlCommand
("SELECT removed_by FROM removedpoints WHERE staff = " + "'" + userBox.Text + "'" + ";", connection))
                {
                    using (MySqlDataReader reader = cmd3.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            removed_by.Items.Add(reader[0].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            if (checkUser != userBox.Text)
            {
                staff.ResetText();
                removed_by.ResetText();
                date_removed.ResetText();
                remove_reason.ResetText();
            }
        }

        private void checkPoints_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
