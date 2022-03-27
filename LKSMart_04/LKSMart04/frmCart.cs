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
    public partial class frmCart : Form
    {
        Customer cs;
        double GetPoint;
        public frmCart(Customer cus)
        {
            cs = db.Customers.Where(s => s.id == cus.id).FirstOrDefault();  
            InitializeComponent();
            this.cs = cs;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            awal();
        }

        private void awal()
        {
            comboBox1.DataSource = db.PaymentTypes.Select(s => s.name);
            tampil();
        }
        private void tampilharga()
        {
            try
            {
                int subtotal = 0, total = 0;
                double platform = 0;
                foreach (Model a in Helper.models)
                {
                    subtotal += a.TotalPrice;
                    platform = .05 * subtotal;
                    total = Convert.ToInt32(platform) + subtotal;
                    GetPoint = subtotal * .20;
                }
                laSubTotal.Text = subtotal.ToString();
                laPlatform.Text = platform.ToString();
                laTotal.Text = total.ToString();
                laAmount.Text = total.ToString();
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }
        private void tampil()
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = Helper.models;
                dataGridView1.DataSource = bs;
                if (bs.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.ColumnHeadersVisible = false;
                }
                else
                {
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[1].DisplayIndex = 9;
                    dataGridView1.Columns[2].DisplayIndex = 9;
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (!string.IsNullOrEmpty(r.Cells[8].Value.ToString()) && r.Cells[8].Value.ToString() != null && r.Cells[8].Value.ToString() != "null" && r.Cells[8].Value.ToString() != "")
                        {
                            var path = r.Cells[8].Value.ToString();
                            r.Cells[0].Value = Image.FromFile(Helper.GetProduct(path));
                        }
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
            tampilharga();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (cs.point == 0)
                    {
                        Helper.message("Your point 0");
                        checkBox1.Checked = false;
                    }
                    else
                    {
                        int subtotal = 0, total = 0, point = 0;
                        double platform = 0;
                        foreach (Model a in Helper.models)
                        {
                            subtotal += a.TotalPrice;
                            platform = .05 * subtotal;
                            total = Convert.ToInt32(platform) + subtotal;
                            GetPoint = 0;
                        }
                        laSubTotal.Text = subtotal.ToString();
                        laPlatform.Text = platform.ToString();
                        laTotal.Text = total.ToString();
                        point = total - cs.point;
                        laPoint.Text = cs.point.ToString();
                        if (Convert.ToInt32(laPoint.Text) > Convert.ToInt32(laTotal.Text))
                        {
                            laAmount.Text = "0";
                        }
                        else
                        {
                            laAmount.Text = point.ToString();
                        }
                    }

                }
                else
                {
                    tampilharga();
                    laPoint.Text = "0";
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                Helper.message("Please select product");
            }
            else
            {
                var ran = Helper.GetRandomString(12);
                HeaderTransaction autonum = db.HeaderTransactions.OrderByDescending(s => s.id).FirstOrDefault();
                int awokwok = autonum.id + 1;
                List<PaymentType> paymentType = db.PaymentTypes.Select(s => s).ToList();
                if (checkBox1.Checked)
                {
                    if (Convert.ToInt32(laPoint.Text) > Convert.ToInt32(laTotal.Text))
                    {
                        db.HeaderTransactions.InsertOnSubmit(new HeaderTransaction
                        {
                            customer_id = cs.id,
                            payment_type_id = paymentType[comboBox1.SelectedIndex].id,
                            datetime = DateTime.Now,
                            sub_total = Convert.ToInt32(laAmount.Text),
                            point_used = Convert.ToInt32(laTotal.Text),
                            payment_code = ran,
                            created_at = DateTime.Now,
                        });
                        db.SubmitChanges();
                        db.PointHistories.InsertOnSubmit(new PointHistory
                        {
                            customer_id = cs.id,
                            header_transaction_id = awokwok,
                            point_gained = 0,
                            point_deducted = Convert.ToInt32(laTotal.Text),
                            point_before = cs.point,
                            point_after =cs.point - Convert.ToInt32(laTotal.Text),
                            created_at = DateTime.Now,
                        });
                        cs.point = cs.point - Convert.ToInt32(laTotal.Text);
                        db.SubmitChanges();
                    }
                    else
                    {
                        db.HeaderTransactions.InsertOnSubmit(new HeaderTransaction
                        {
                            customer_id = cs.id,
                            payment_type_id = paymentType[comboBox1.SelectedIndex].id,
                            datetime = DateTime.Now,
                            sub_total = Convert.ToInt32(laAmount.Text),
                            point_used = Convert.ToInt32(laPoint.Text),
                            payment_code = ran,
                            created_at = DateTime.Now,
                        });
                        db.SubmitChanges();
                        db.PointHistories.InsertOnSubmit(new PointHistory
                        {
                            customer_id = cs.id,
                            header_transaction_id = awokwok,
                            point_gained = 0,
                            point_deducted = Convert.ToInt32(laPoint.Text),
                            point_before = cs.point,
                            point_after = 0,
                            created_at = DateTime.Now,
                        });
                        cs.point =0;
                        db.SubmitChanges();
                    }
                    foreach (Model a in Helper.models)
                    {
                        Product pr = db.Products.Where(s => s.id == a.ID).FirstOrDefault();
                        db.DetailTransactions.InsertOnSubmit(new DetailTransaction
                        {

                            header_transaction_id = awokwok,
                            product_id = a.ID,
                            price = a.ProductPrice,
                            quantity = a.Quantity,
                            created_at= DateTime.Now,
                        });
                        pr.stock = pr.stock - a.Quantity;
                        db.SubmitChanges();
                    }
                }
                else
                {
                    db.HeaderTransactions.InsertOnSubmit(new HeaderTransaction
                    {
                        customer_id = cs.id,
                        payment_type_id = paymentType[comboBox1.SelectedIndex].id,
                        datetime = DateTime.Now,
                        sub_total = Convert.ToInt32(laAmount.Text),
                        point_used = 0,
                        payment_code = ran,
                        created_at = DateTime.Now,
                    });
                    db.SubmitChanges();
                    db.PointHistories.InsertOnSubmit(new PointHistory
                    {
                        customer_id = cs.id,
                        header_transaction_id = awokwok,
                        point_gained = Convert.ToInt32(GetPoint),
                        point_deducted = 0,
                        point_before = cs.point,
                        point_after = cs.point + Convert.ToInt32(GetPoint),
                        created_at = DateTime.Now,
                    });
                    cs.point = cs.point + Convert.ToInt32(GetPoint);
                    db.SubmitChanges();
                    foreach (Model a in Helper.models)
                    {
                        Product pr = db.Products.Where(s => s.id == a.ID).FirstOrDefault();
                        db.DetailTransactions.InsertOnSubmit(new DetailTransaction
                        {

                            header_transaction_id = awokwok,
                            product_id = a.ID,
                            price = a.ProductPrice,
                            quantity = a.Quantity,
                            created_at = DateTime.Now,
                        });
                        pr.stock = pr.stock - a.Quantity;
                        db.SubmitChanges();
                    }
                }
                Helper.code = ran;
                Helper.namePayment = comboBox1.Text;
                Helper.models.Clear();
                this.Hide();
                new frmNotif(cs).ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == 1)
            {
                Helper.id = Convert.ToInt32(r.Cells[3].Value);
                Helper.price = Convert.ToInt32(r.Cells[5].Value);
                Helper.stock = Convert.ToInt32(r.Cells[7].Value);
                Helper.qty = Convert.ToInt32(r.Cells[6].Value);
                Helper.name = r.Cells[4].Value.ToString();
                Helper.imagename = r.Cells[8].Value?.ToString();
                Helper.category = r.Cells[10].Value?.ToString();
                this.Hide();
                new frmAddtocart(cs).Show();
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure to delete?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Helper.model = new Model();
                    Helper.model = Helper.models[e.RowIndex];
                    Helper.models.Remove(Helper.model);
                    tampil();
                }
                
            }
        }
    }
}
