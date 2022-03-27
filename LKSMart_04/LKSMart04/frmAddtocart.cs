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
    public partial class frmAddtocart : Form
    {
        Customer cs;
        public frmAddtocart(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void frmAddtocart_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampil()
        {
            try
            {
                laNama.Text = Helper.name;
                laStock.Text = Helper.stock.ToString();
                laQty.Text = Helper.qty.ToString();
                laPrice.Text = Helper.price.ToString();
                laCategory.Text = Helper.category.ToString();
                if (!string.IsNullOrEmpty(Helper.imagename) && Helper.imagename != "null")
                {
                    pictureBox2.Image = Image.FromFile(Helper.GetProduct(Helper.imagename));
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(laQty.Text) > 0)
            {
                laQty.Text = (int.Parse(laQty.Text) - 1).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!laQty.Text.Contains(laStock.Text))
            {
                laQty.Text = (int.Parse(laQty.Text) + 1).ToString();
            }
            else
            {
                Helper.message("Stock terbatas");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (laQty.Text == "0")
                {
                    Helper.message("Value can't be 0");
                }
                else
                {
                    Model data = Helper.models.Where(s => s.ID == Helper.id).FirstOrDefault();
                    if (data != null)
                    {
                        data.Quantity = Convert.ToInt32(laQty.Text);
                        this.Hide();
                        new frmCart(cs).Show();
                    }
                    else
                    {
                        Helper.models.Add(new Model
                        {
                            ID = Helper.id,
                            ProductName = Helper.name,
                            ProductPrice = Helper.price,
                            Quantity = Convert.ToInt32(laQty.Text),
                            Stock = Helper.stock,
                            NameImage = Helper.imagename,
                            Categoryname = Helper.category
                        });
                        Helper.message("Successfully add to cart");
                        this.Hide();
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }
    }
}
