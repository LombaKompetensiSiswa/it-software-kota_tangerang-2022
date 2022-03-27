using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LKSMart_05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string nama = label7.Text = "DD:MM:yy";

            nama.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
