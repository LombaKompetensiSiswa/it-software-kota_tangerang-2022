using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LKSMart_05
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-GGEOP5I\ITSS;Initial Catalog=LKSMart;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Customer where phone_number='" + textBox1.Text + "' or email='" + textBox1.Text + "' and pin_number= '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm frmMain = new MainForm();
                frmMain.Show();
                this.Hide();
            }
        }
    }
}
