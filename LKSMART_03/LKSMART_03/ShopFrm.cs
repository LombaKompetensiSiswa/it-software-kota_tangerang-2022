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

namespace LKSMART_03
{
    public partial class ShopFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        public ShopFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }
        private void invisible()
        {
            llmakmin.Visible = false;
            llAirMin.Visible = false;
            llbiswaf.Visible = false;
            llcokelat.Visible = false;
            llkacang.Visible = false;
            llkeripik.Visible = false;
            llmikem.Visible = false;
            llnuget.Visible = false;
            llpulpen.Visible = false;
        }
        private void visible()
        {
            llmakmin.Visible = true;
            llAirMin.Visible = true;
            llbiswaf.Visible = true;
            llcokelat.Visible = true;
            llkacang.Visible = true;
            llkeripik.Visible = true;
            llmikem.Visible = true;
            llnuget.Visible = true;
            llpulpen.Visible = true;
        }
        private void ShopFrm_Load(object sender, EventArgs e)
        {
            tampil();
            invisible();
        }

        private void tampil()
        {
            try
            {
                dataGridView1.DataSource = from a in db.Products
                                           where SqlMethods.Like(a.name, "%" + tbSearch.Text + "%")
                                           where a.deleted_at == null
                                           select new
                                           {
                                               a.id,
                                               ProductName = a.name,
                                               ProductPrice = a.price,
                                               ProductStock = a.stock,
                                               Category = a.Category.name,
                                               ImageName = a.image_name
                                           };
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["Category"].Visible = false;
                dataGridView1.Columns["ImageName"].Visible = false;
                dataGridView1.Columns[1].DisplayIndex = 6;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (!string.IsNullOrWhiteSpace(item.Cells["ImageName"].Value.ToString()) && item.Cells["ImageName"].Value.ToString() != null
                       && item.Cells["ImageName"].Value.ToString() != "null" && item.Cells["ImageName"].Value.ToString() != "")
                    {
                        var path = Helper.GetProductPictures(item.Cells["ImageName"].Value.ToString());
                        Bitmap bm = new Bitmap(path);
                        item.Cells[0].Value = bm;
                    }
                }
            }
            catch 
            {

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 1)
                {
                    DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                    Helper.cc.idproduct = Convert.ToInt32(r.Cells["Id"].Value.ToString());
                    Helper.cc.ProductName = r.Cells["ProductName"].Value.ToString();
                    Helper.cc.ProductPrice = Convert.ToDecimal(r.Cells["ProductPrice"].Value.ToString());
                    Helper.cc.ProductStock = Convert.ToInt32(r.Cells["ProductStock"].Value.ToString());
                    Helper.cc.Category =r.Cells["Category"].Value.ToString();
                    Helper.cc.ImageNames = r.Cells["ImageName"].Value.ToString();
                    new AddToCart(cs).ShowDialog();
                }
            }
        }
        private void tampilCategory(string category)
        {
            dataGridView1.DataSource = from a in db.Products
                                       where SqlMethods.Like(a.name, "%" + tbSearch.Text + "%")
                                       where a.deleted_at == null
                                       where a.Category.name == category
                                       select new
                                       {
                                           a.id,
                                           ProductName = a.name,
                                           ProductPrice = a.price,
                                           ProductStock = a.stock,
                                           Category = a.Category.name,
                                           ImageName = a.image_name
                                       };
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Category"].Visible = false;
            dataGridView1.Columns["ImageName"].Visible = false;
            dataGridView1.Columns[1].DisplayIndex = 6;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!string.IsNullOrWhiteSpace(item.Cells["ImageName"].Value.ToString()) && item.Cells["ImageName"].Value.ToString() != null
                   && item.Cells["ImageName"].Value.ToString() != "null" && item.Cells["ImageName"].Value.ToString() != "")
                {
                    var path = Helper.GetProductPictures(item.Cells["ImageName"].Value.ToString());
                    Bitmap bm = new Bitmap(path);
                    item.Cells[0].Value = bm;
                }
            }
        }
        private void tampilfilter()
        {
            try
            {
                int min = Convert.ToInt32(tbMin.Text);
                int max = Convert.ToInt32(tbmax.Text);
                if (min != 0 || max != 0)
                {
                    if (min < max)
                    {
                        dataGridView1.DataSource = from a in db.Products
                                                   where SqlMethods.Like(a.name, "%" + tbSearch.Text + "%")
                                                   where a.deleted_at == null
                                                   where a.price >= min && a.price <= max
                                           select new
                                           {
                                               a.id,
                                               ProductName = a.name,
                                               ProductPrice = a.price,
                                               ProductStock = a.stock,
                                               Category = a.Category.name,
                                               ImageName = a.image_name
                                           };
                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["Category"].Visible = false;
                        dataGridView1.Columns["ImageName"].Visible = false;
                        dataGridView1.Columns[1].DisplayIndex = 6;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            if (!string.IsNullOrWhiteSpace(item.Cells["ImageName"].Value.ToString()) && item.Cells["ImageName"].Value.ToString() != null
                               && item.Cells["ImageName"].Value.ToString() != "null" && item.Cells["ImageName"].Value.ToString() != "")
                            {
                                var path = Helper.GetProductPictures(item.Cells["ImageName"].Value.ToString());
                                Bitmap bm = new Bitmap(path);
                                item.Cells[0].Value = bm;
                            }
                        }
                    }
                    else
                    {
                        tampil();
                    }
                }
                else
                {
                    tampil();
                }
               
            }
            catch 
            {
                tampil();
            }
        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {
            tampilfilter();
        }

        private void tbmax_TextChanged(object sender, EventArgs e)
        {
            tampilfilter();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainFrm(cs).Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llbiswaf.Visible == false)
            {
                visible();
            }
            else
            {
                invisible();
                llmakmin.Visible = true;
            }
        }

        private void llall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llmakmin.Visible == false)
            {
                llmakmin.Visible = true;
                tampil();
            }
            else
            {
                llmakmin.Visible = false;
                invisible();
                tampil();
            }
        }

        private void llkeripik_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Keripik");
        }

        private void llbiswaf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Biskuit & Wafer");

        }

        private void llkacang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Kacang");

        }

        private void llcokelat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Cokelat");

        }

        private void llAirMin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Air Mineral");

        }

        private void llmikem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Minuman Kemasan");

        }

        private void llnuget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Nugget");

        }

        private void llpulpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tampilCategory("Pulpen");

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tampil();
        }
    }
}
