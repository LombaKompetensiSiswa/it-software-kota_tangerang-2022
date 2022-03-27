using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMART_03
{
    public partial class MainFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        public MainFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cs = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
                timer1.Start();
                lbluser.Text = "Welcome, " + cs.name;
                if(!string.IsNullOrWhiteSpace(cs.profile_image_name))
                    pccustomer.Image = Image.FromFile(Helper.GetprofilePictures(cs.profile_image_name));

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new LoginFrm().Show();
            }
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure want exit this Application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss");
        }

        private void pcprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileFrm(cs).Show();
        }

        private void pcShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ShopFrm(cs).Show();
        }

        private void pctransaction_Click(object sender, EventArgs e)
        {
            new TransactionHistoryFrm(cs).ShowDialog();
        }

        private void pcpoint_Click(object sender, EventArgs e)
        {
            new PointHistoryFrm(cs).ShowDialog();

        }

        private void pccart_Click(object sender, EventArgs e)
        {
            new  CartFrm(cs).ShowDialog();

        }
    }
}
