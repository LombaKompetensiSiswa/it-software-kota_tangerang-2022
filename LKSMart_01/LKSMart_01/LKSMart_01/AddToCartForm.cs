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
    public partial class AddToCartForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        private SqlDataAdapter adapter;
        private DataSet ds;
        private int productID;
        private int _id;
        public AddToCartForm(int productID, int id)
        {
            this.productID = productID;
            this._id = id;
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Product WHERE id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this.productID);
            ds = new DataSet();
            adapter.Fill(ds);
            product.Text = ds.Tables[0].Rows[0]["name"].ToString();
            price.Text = ds.Tables[0].Rows[0]["price"].ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\" + ds.Tables[0].Rows[0]["image_name"].ToString());
            }catch
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\not_available.png");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // do submit
            /*if (Convert.ToInt32(Qty.Text) > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cart", conn);

            }*/
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT stock FROM Product WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", this.productID);
            if (Convert.ToInt32(Qty.Text) < Convert.ToInt32(cmd.ExecuteScalar()))
            {
                Qty.Text = (Convert.ToInt32(Qty.Text) + 1).ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decrease
            if (Convert.ToInt32(Qty.Text) > 0)
            {
                Qty.Text = (Convert.ToInt32(Qty.Text) - 1).ToString();
            }
        }
    }
}
