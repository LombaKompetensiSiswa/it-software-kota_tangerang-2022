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
    public partial class ShopForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        private SqlDataAdapter adapter;
        private DataSet ds;
        private int _id;
        public ShopForm(int id)
        {
            this._id = id;
            InitializeComponent();
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
            LoadProduct();
        }

        private void LoadProduct()
        {
            if (keyword.Text != string.Empty && min.Text != string.Empty && max.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price<=@max AND price>=@min AND name LIKE @keyword", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@min", Convert.ToDouble(min.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@max", Convert.ToDouble(max.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", '%' + keyword.Text + '%');
            }
            else if (keyword.Text != string.Empty && max.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price<=@max AND name LIKE @keyword", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@max", Convert.ToDouble(max.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", '%' + keyword.Text + '%');
            }
            else if (keyword.Text != string.Empty && min.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price>=@min AND name LIKE @keyword", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@min", Convert.ToDouble(min.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", '%' + keyword.Text + '%');
            }
            else if (min.Text != string.Empty && max.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price<=@max AND price>=@min", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@min", Convert.ToDouble(min.Text));
                adapter.SelectCommand.Parameters.AddWithValue("@max", Convert.ToDouble(max.Text));
            }
            else if (keyword.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE name LIKE @keyword", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", '%' + keyword.Text + '%');
            }
            else if (min.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price >= @min", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@min", Convert.ToDouble(min.Text));
            }
            else if (max.Text != string.Empty)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product WHERE price <= @max", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@max", Convert.ToDouble(max.Text));
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT * FROM Product", conn);
            }
            ds =  new DataSet();
            adapter.Fill(ds);

            while (panel1.Controls.Count > 0)
            {
                panel1.Controls[0].Dispose();
            }

            List<Panel> products = new List<Panel>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                products.Add(new Panel());
                PictureBox picture = new PictureBox();
                Label name = new Label(),
                      price = new Label(), 
                      stock = new Label();
                Button cart = new Button();
                try
                {
                    picture.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\products\" +
                        ds.Tables[0].Rows[i]["image_name"]);
                }
                catch
                {
                    picture.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\products\not_available.png");
                }
                name.Text = ds.Tables[0].Rows[i]["name"].ToString();
                price.Text = ds.Tables[0].Rows[i]["price"].ToString();
                stock.Text = ds.Tables[0].Rows[i]["stock"].ToString();
                cart.Text = "Add To Cart";
                cart.Name = ds.Tables[0].Rows[i]["id"].ToString();
                cart.BackColor = Color.Black;
                cart.ForeColor = Color.White;
                cart.Click += new EventHandler(AddToCart);

                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Location = new Point(3, 3);
                picture.Width = 74;
                picture.Height = 74;
                
                name.AutoSize = true;
                price.AutoSize = true;
                stock.AutoSize = true;
                cart.AutoSize = true;

                name.Location = new Point(100, 30);
                price.Location = new Point(250, 30);
                stock.Location = new Point(450, 30);
                cart.Location = new Point(550, 25);

                products[i].Width = 755;
                products[i].Height = 80;
                products[i].Location = new Point(10, 10 * (i + 1) + 80 * i);
                products[i].BackColor = Color.White;
                products[i].Controls.AddRange(new Control[] {picture, name, price, stock, cart});
            }

            foreach (Panel product in products)
            {
                panel1.Controls.Add(product);
            }
        }

        private void AddToCart(object sender, EventArgs e)
        {
            Button button = sender as Button;
            AddToCartForm cart = new AddToCartForm(Convert.ToInt32(button.Name), this._id);
            cart.ShowDialog(this);
        }

        private void max_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(min.Text, "^[0-9]+$") && min.Text.Length > 0)
            {
                min.Text = min.Text.Substring(0, min.Text.Length - 1);
                min.SelectionStart = min.Text.Length;
                min.SelectionLength = 0;
            }
            LoadProduct();
        }

        private void min_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(max.Text, "^[0-9]+$") && max.Text.Length > 0)
            {
                max.Text = max.Text.Substring(0, min.Text.Length - 1);
                max.SelectionStart = max.Text.Length;
                max.SelectionLength = 0;
            }
            LoadProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
