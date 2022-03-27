using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart04
{
    public partial class frmShop : Form
    {
        Customer cs;
        decimal MinPrice, MaxPrice;
        public frmShop(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampilImage()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (!string.IsNullOrEmpty(r.Cells[6].Value.ToString())&& r.Cells[6].Value.ToString() != null && r.Cells[6].Value.ToString()!="null"&& r.Cells[6].Value.ToString() != "")
                {
                    var path = r.Cells[6].Value.ToString();
                    r.Cells[0].Value = Image.FromFile(Helper.GetProduct(path));
                }
            }
        }

        private void tampil()
        {
            try
            {
                dataGridView1.DataSource = from a in db.Products
                                           where a.deleted_at == null
                                           select new
                                           {
                                               a.id,
                                               ProductName = a.name,
                                               ProductPrice = a.price,
                                               ProductStock = a.stock,
                                               a.image_name,
                                               a.Category.name
                                           };
                dataGridView1.Columns[1].DisplayIndex = 6;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                tampilImage();
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    MinPrice = Convert.ToDecimal(textBox2.Text);
                    dataGridView1.DataSource = from a in db.Products
                                               where a.deleted_at == null
                                               where a.price > MinPrice
                                               select new
                                               {
                                                   a.id,
                                                   ProductName = a.name,
                                                   ProductPrice = a.price,
                                                   ProductStock = a.stock,
                                                   a.image_name,
                                                   a.Category.name
                                               };
                    dataGridView1.Columns[1].DisplayIndex = 6;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    tampilImage();
                }
                else
                {
                    tampil();
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    MaxPrice = Convert.ToDecimal(textBox3.Text);
                    dataGridView1.DataSource = from a in db.Products
                                               where a.deleted_at == null
                                               where a.price > MinPrice && a.price < MaxPrice
                                               select new
                                               {
                                                   a.id,
                                                   ProductName = a.name,
                                                   ProductPrice = a.price,
                                                   ProductStock = a.stock,
                                                   a.image_name,
                                                   a.Category.name
                                               };
                    dataGridView1.Columns[1].DisplayIndex = 6;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    tampilImage();
                }
                else
                {
                    tampil();
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampil();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilProduct(laKeripik.Text);
        }

        private void tampilProduct(string name)
        {
            try
            {
                dataGridView1.DataSource = from a in db.Products
                                           where a.deleted_at == null
                                           where a.Category.name == name
                                           select new
                                           {
                                               a.id,
                                               ProductName = a.name,
                                               ProductPrice = a.price,
                                               ProductStock = a.stock,
                                               a.image_name,
                                               a.Category.name
                                           };
                dataGridView1.Columns[1].DisplayIndex = 6;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                tampilImage();
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
         
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                    Helper.id = Convert.ToInt32(r.Cells[2].Value);
                    Helper.price = Convert.ToInt32(r.Cells[4].Value);
                    Helper.stock = Convert.ToInt32(r.Cells[5].Value);
                    Helper.name = r.Cells[3].Value.ToString();
                    Helper.imagename = r.Cells[6].Value?.ToString();
                    Helper.category = r.Cells[7].Value.ToString();
                    if (Helper.stock == 0)
                    {
                        Helper.message("Stock tidak tersedia");
                    }
                    else
                    {
                        Model data = Helper.models.Where(s => s.ID == Helper.id).FirstOrDefault();
                        if (data != null)
                        {
                            Helper.message("Product telah tersedia di cart");
                        }
                        else
                        {
                            Helper.qty = 0;
                            new frmAddtocart(cs).ShowDialog();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }
        private void laAirmineral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilProduct(laAirmineral.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = from a in db.Products
                                           where a.deleted_at == null
                                           where SqlMethods.Like(a.name, "%" + textBox1.Text + "%")
                                           select new
                                           {
                                               a.id,
                                               ProductName = a.name,
                                               ProductPrice = a.price,
                                               ProductStock = a.stock,
                                               a.image_name,
                                               a.Category.name
                                           };
                dataGridView1.Columns[1].DisplayIndex = 6;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                tampilImage();
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }
    }
}
