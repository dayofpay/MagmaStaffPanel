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
    public partial class playersHistory : Form
    {
        public playersHistory()
        {
            InitializeComponent();
        }

        private void playersHistory_Load(object sender, EventArgs e)
        {
            API.ConnectDB();
            MySqlCommand checkAll = new MySqlCommand("SELECT * FROM PunishmentHistory", API.connection);
            checkAll.ExecuteScalar();
            using (MySqlDataReader reader = checkAll.ExecuteReader())
            {
                while (reader.Read())
                {
                    allPunishments.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
                reader.Close();
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand checkPunishments = new MySqlCommand("SELECT * FROM Punishments WHERE name = '" + user.Text + "'", API.connection);
                checkPunishments.ExecuteScalar();
                using (MySqlDataReader reader = checkPunishments.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        punishments.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
                    reader.Close();
                }
                MySqlCommand checkExpired = new MySqlCommand("SELECT * FROM PunishmentHistory WHERE name = '" + user.Text + "'", API.connection);
                checkExpired.ExecuteScalar();
                using (MySqlDataReader reader = checkExpired.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Expired.Rows.Add(reader.GetString(1), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
                    reader.Close();
                }
            }
            catch(MySqlException error)
            {
                MessageBox.Show("Грешка", "MagmaCraft | Systems | 2.3");
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DefaultUI goBack = new DefaultUI();
            this.Hide();
            goBack.ShowDialog();
        }
    }
}
