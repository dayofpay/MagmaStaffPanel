using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagmaStaffPanel
{
    class API
    {
        public static string GetUsername = "";
        public static string GetPassword = "";
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
    }
}
