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

namespace LKSMart_01
{
    public partial class MainForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        private SqlDataAdapter adapter;
        private DataSet ds;
        private int _id;
        public MainForm(int id)
        {
            this._id = id;
            InitializeComponent();
            
            adapter = new SqlDataAdapter("SELECT * FROM Customer WHERE id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this._id);
            ds = new DataSet();
            adapter.Fill(ds);
            username.Text = ds.Tables[0].Rows[0]["name"].ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\profile_pictures\" + 
                    (ds.Tables[0].Rows[0]["profile_image_name"].ToString()) + ".png");
            }
            catch
            {
                //DO NOTHING
            }
            timer1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            PorfileForm profile = new PorfileForm(this._id);
            profile.ShowDialog(this);
            this.Show();
            adapter = new SqlDataAdapter("SELECT * FROM Customer WHERE id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this._id);
            ds = new DataSet();
            adapter.Fill(ds);
            username.Text = ds.Tables[0].Rows[0]["name"].ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\profile_pictures\" +
                    (ds.Tables[0].Rows[0]["profile_image_name"].ToString()) + ".png");
                pictureBox1.Refresh();
            }
            catch
            {
                //DO NOTHING
            }
        }

        private void shop_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shop = new ShopForm(this._id);
            shop.ShowDialog(this);
            this.Show();
        }

        private void transactionhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            // here
            this.Show();
        }

        private void pointhistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointForm point = new PointForm(this._id);
            point.ShowDialog(this);
            this.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
