using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart04
{
    public partial class frmMain : Form
    {
        Customer cs;
        public frmMain(Customer cus)
        {
            cs = db.Customers.Where(s => s.id == cus.id).FirstOrDefault();  
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void timer1_Tick(object sender, EventArgs e)
        {
            laTime.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            laNama.Text = $"Welcome, {cs.name}";
            timer1.Start();
            if (!string.IsNullOrEmpty(cs.profile_image_name))
            {
                picCustomer.Image = Image.FromFile(Helper.GetProfile(cs.profile_image_name));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout?","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Hide();
                new frmLogin().ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProfile(cs).Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmShop(cs).Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTransaksiHistory(cs).Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmPointHistory(cs).Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCart(cs).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
