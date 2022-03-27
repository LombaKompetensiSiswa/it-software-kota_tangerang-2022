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
    public partial class AddToCart : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        CartClass data;
        public AddToCart(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }
        int qty;
        private void AddToCart_Load(object sender, EventArgs e)
        {
            try
            {
                data = Helper.lc.Where(s => s.idproduct == Helper.cc.idproduct).FirstOrDefault();
                laname.Text = data == null ? Helper.cc.ProductName : data.ProductName;
                lanameatas.Text = data == null ? Helper.cc.ProductName : data.ProductName;
                laprice.Text = data == null ? Helper.cc.ProductPrice.ToString() : data.ProductPrice.ToString();
                lastock.Text = data == null ? Helper.cc.ProductStock.ToString() : data.ProductStock.ToString();
                lacategory.Text = data == null ? Helper.cc.Category : data.Category;
                laqty.Text = data == null ? "0" : data.Quantity.ToString();
                qty = Convert.ToInt32(laqty.Text);
                if (!string.IsNullOrWhiteSpace(data == null ? Helper.cc.ImageNames : data.ImageNames))
                    if (Helper.cc.ImageNames == null || Helper.cc.ImageNames == "null" || Helper.cc.ImageNames == "")
                    {
                    }
                    else
                    {
                        pccustomer.Image = Image.FromFile(Helper.GetProductPictures(Helper.cc.ImageNames));
                    }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }

        }

        private void btnMinn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(laqty.Text) == 0)
            {
                laqty.Text = "0";
            }
            else
            {
                qty--;
                laqty.Text = qty.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(laqty.Text) == Helper.cc.ProductStock)
            {
                Helper.showMessage("Sorry, Product out of stock!");
            }
            else
            {
                qty++;
                laqty.Text = qty.ToString();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (laqty.Text == "0")
            {
                Helper.showMessage("Please input quantity product first!");
            }
            else
            {
                CartClass cc = Helper.lc.Where(s => s.idproduct == Helper.cc.idproduct).FirstOrDefault();
                if (cc == null)
                {
                    Helper.lc.Add(new CartClass
                    {
                        idproduct = Helper.cc.idproduct,
                        ProductName = Helper.cc.ProductName,
                        ProductPrice = Helper.cc.ProductPrice,
                        ProductStock = Helper.cc.ProductStock,
                        ImageNames = Helper.cc.ImageNames,
                        Category = Helper.cc.Category,
                        Quantity = Convert.ToInt32(laqty.Text)
                    });
                    Helper.showMessage("Success submit product to cart!");
                    this.Hide();
                }
                else
                {
                    cc.Quantity = Convert.ToInt32(laqty.Text);
                    Helper.showMessage("Success Update product to cart!");
                    this.Hide();
                }
            }
        }
    }
}
