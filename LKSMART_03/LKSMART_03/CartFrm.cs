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
    public partial class CartFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        int pointgain,total,remaining;
        public CartFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void btnSubmit_Load(object sender, EventArgs e)
        {
            tampil();
            cbPAyment.DataSource = db.PaymentTypes.Select(s => s.name).ToList();
        }
        private void bersih()
        {
            laavailablepoint.Text = "0";
            lasubtotal.Text = "0";
            laplatform.Text = "0";
            latotal.Text = "0";
            lammount.Text = "0";
            laremaining.Text = "0";
        }

        private void tampil()
        {
            try
            {
                dataGridView1.DataSource = null;
                if (Helper.lc.Count > 0)
                {
                    dataGridView1.DataSource = Helper.lc;
                    dataGridView1.Columns["idProduct"].Visible = false;
                    dataGridView1.Columns["ProductStock"].Visible = false;
                    dataGridView1.Columns["Category"].Visible = false;
                    dataGridView1.Columns["ImageNames"].Visible = false;
                    dataGridView1.Columns["Subtotal"].Visible = false;
                    dataGridView1.Columns[1].DisplayIndex = dataGridView1.Columns.Count - 1;
                    dataGridView1.Columns[2].DisplayIndex = dataGridView1.Columns.Count - 2;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (!string.IsNullOrWhiteSpace(item.Cells["ImageNames"].Value.ToString()) && item.Cells["ImageNames"].Value.ToString() != null
                           && item.Cells["ImageNames"].Value.ToString() != "null" && item.Cells["ImageNames"].Value.ToString() != "")
                        {
                            var path = Helper.GetProductPictures(item.Cells["ImageNames"].Value.ToString());
                            Bitmap bm = new Bitmap(path);
                            item.Cells[0].Value = bm;
                        }
                    }
                    tampillable();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    checkBox1.Enabled = false;
                    bersih();
                }

            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Customer cus = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();

            if (cus.point == 0)
            {
                Helper.showMessage("Sorry, you have no point!");
                checkBox1.Checked = false;
            }
            else
            {
                if (checkBox1.Checked)
                {
                    int subtotal = 0, platformFee = 0,ammounttopay;
                    foreach (CartClass item in Helper.lc)
                    {
                        subtotal += item.Subtotal;
                        platformFee = Convert.ToInt32(subtotal * 0.05);
                    }
                    total = subtotal + platformFee;
                    ammounttopay = total - cus.point;
                    lasubtotal.Text = subtotal.ToString();
                    laplatform.Text = platformFee.ToString();
                    latotal.Text = total.ToString();
                    laavailablepoint.Text = cus.point.ToString() ;
                    lammount.Text = ammounttopay.ToString();
                    if (total < cus.point)
                    {
                        remaining = cus.point - total;
                        laremaining.Text = remaining.ToString();
                        lammount.Text = "0";
                    }
                }
                else
                {
                    tampil();
                }
            }
        }
        private void tampillable()
        {
            int subtotal = 0, platformFee = 0;
            Customer cus = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
            foreach (CartClass item in Helper.lc)
            {
                subtotal += item.Subtotal;
                platformFee = Convert.ToInt32(subtotal * 0.05);
                pointgain = Convert.ToInt32(subtotal * 0.20);
            }
            total = subtotal + platformFee;
            lasubtotal.Text = subtotal.ToString();
            laplatform.Text = platformFee.ToString();
            latotal.Text = total.ToString();
            laavailablepoint.Text = "0";
            lammount.Text = total.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == 2)
                    {
                        DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                        Helper.cc.idproduct = Convert.ToInt32(r.Cells["idProduct"].Value.ToString());
                        Helper.cc.ProductName = r.Cells["ProductName"].Value.ToString();
                        Helper.cc.ProductPrice = Convert.ToDecimal(r.Cells["ProductPrice"].Value.ToString());
                        Helper.cc.ProductStock = Convert.ToInt32(r.Cells["ProductStock"].Value.ToString());
                        Helper.cc.Category = r.Cells["Category"].Value.ToString();
                        Helper.cc.ImageNames = r.Cells["ImageNames"].Value.ToString();
                        Helper.cc.Quantity = Convert.ToInt32(r.Cells["Quantity"].Value.ToString());
                        new AddToCart(cs).ShowDialog();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        if (MessageBox.Show("Are you sure want delete this product in cart?", "Inforamtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                            int id = Convert.ToInt32(r.Cells["idProduct"].Value.ToString());
                            Helper.lc.Remove(Helper.lc.Where(s => s.idproduct == id).FirstOrDefault());
                        }
                    }
                    tampil();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.lc.Count == 0)
                {
                    Helper.showMessage("Please select product in cart first!");
                }
                else
                {
                    HeaderTransaction ht = db.HeaderTransactions.Where(s => s.id == cs.id).FirstOrDefault();
                    List<PaymentType> lp = db.PaymentTypes.Select(s => s).ToList();
                    Product pro = db.Products.Where(s => s.id == Helper.cc.idproduct).FirstOrDefault();

                    string randomcode = Helper.RandomCode(12);
                    if (ht != null)
                    {
                        db.HeaderTransactions.InsertOnSubmit(new HeaderTransaction
                        {
                            customer_id = cs.id,
                            payment_type_id = lp[cbPAyment.SelectedIndex].id,
                            datetime = DateTime.Now,
                            created_at = DateTime.Now,
                            sub_total = Convert.ToInt32(lasubtotal.Text),
                            point_used = Convert.ToInt32(laavailablepoint.Text),
                            payment_code = randomcode,
                        });
                        db.SubmitChanges();
                        foreach (CartClass item in Helper.lc)
                        {
                            HeaderTransaction htid = db.HeaderTransactions.OrderByDescending(s => s.id).FirstOrDefault();

                            db.DetailTransactions.InsertOnSubmit(new DetailTransaction
                            {
                                header_transaction_id = htid.id,
                                product_id = item.idproduct,
                                price = item.ProductPrice,
                                quantity = item.Quantity,
                                created_at = DateTime.Now,
                            });
                            if (pro != null)
                            {
                                Product pr = db.Products.Where(s => s.id == item.idproduct).FirstOrDefault();
                                var stock = pr.stock - item.Quantity;
                                pr.id = item.idproduct;
                                pr.stock = stock;
                                db.SubmitChanges();
                            }
                        }
                        if (checkBox1.Checked)
                        {
                            HeaderTransaction htid = db.HeaderTransactions.OrderByDescending(s => s.id).FirstOrDefault();
                            Customer cus = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
                            db.PointHistories.InsertOnSubmit(new PointHistory
                            {
                                customer_id = cs.id,
                                header_transaction_id = htid.id,
                                point_gained = 0,
                                point_deducted = Convert.ToInt32(laavailablepoint.Text),
                                point_before = cus.point,
                                point_after = Convert.ToInt32(laremaining.Text),
                                created_at = DateTime.Now,
                            });
                            if (total < cus.point)
                            {
                                //cus.id = cs.id;
                                cus.point = remaining;
                            }
                            else
                            {
                                cus.point = 0;
                            }
                            db.SubmitChanges();
                        }
                        else
                        {
                            HeaderTransaction htid = db.HeaderTransactions.OrderByDescending(s => s.id).FirstOrDefault();
                            Customer cus = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
                            db.PointHistories.InsertOnSubmit(new PointHistory
                            {
                                customer_id = cs.id,
                                header_transaction_id = htid.id,
                                point_gained = pointgain,
                                point_deducted = Convert.ToInt32(laavailablepoint.Text),
                                point_before = cus.point,
                                point_after = cus.point + pointgain,
                                created_at = DateTime.Now,
                            });
                            cus.point = pointgain + cus.point;
                            db.SubmitChanges();
                        }
                        Helper.paymentCode = randomcode;
                        Helper.paymentType = cbPAyment.Text;
                        Helper.lc.Clear();
                        new NotificationFrm().ShowDialog();
                        bersih();
                        this.Hide();
                    }
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
