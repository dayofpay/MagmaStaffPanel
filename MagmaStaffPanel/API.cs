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

    class API
    {
        MySqlConnection con = new MySqlConnection(DefaultUI.conString);
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        public static MySqlConnection connection;
        public static string server;
        public static string database;
        public static string user;
        public static string password;
        public static string port;
        public static string connectionString;
        public static string sslM;
        public static string conString = "";
        public static string GetUsername = "";
        public static string GetPassword = "";
        public static string getPin = "MAGMAX2021ZVX1";
        public static string getError = "";
        public static string defaultRole = "Helper";
        public static string checkStatus = "";
        public static string checkConclusion = "";
        public static string startedCheckTime = "";
        public static string currentChecked = "";
        public void GetTime()
        {
            DateTime.Now.ToString();
        }
        public static void ConnectDB()
        {
            server = "vashiqt_serv";
            database = "vashiqt_serv";
            user = "vashiqt_serv";
            password = "vashiqt_serv";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            connection.Open();
        }
    }
}
