using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagmaStaffPanel
{
    public partial class pinRequire : Form
    {
        public pinRequire()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == API.getPin)
            {
                UserControl userControl = new UserControl();
                this.Hide();
                userControl.ShowDialog();
            }
            else
            {
                MessageBox.Show("Грешен Пин !!!");
            }
        }
    }
}
