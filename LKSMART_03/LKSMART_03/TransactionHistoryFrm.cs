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
    public partial class TransactionHistoryFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        int idheader;
        public TransactionHistoryFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void TransactionHistoryFrm_Load(object sender, EventArgs e)
        {
            tampildg1();
        }

        private void tampildg1()
        {
            dataGridView1.DataSource = from a in db.HeaderTransactions
                                       join b in db.PointHistories
                                       on a.id equals b.header_transaction_id
                                       where a.customer_id == cs.id
                                       group new { a, b } by new
                                       {
                                           a.id,
                                           a.customer_id,
                                           date = a.datetime,
                                           TotalPayment = a.sub_total,
                                           PointGained = b.point_gained,
                                           PointDeducted = b.point_deducted,
                                           PaymenCode = a.payment_code
                                       } into g
                                       select new
                                       {
                                           g.Key.id,
                                           g.Key.customer_id,
                                           g.Key.date,
                                           g.Key.TotalPayment,
                                           g.Key.PointGained,
                                           g.Key.PointDeducted,
                                           g.Key.PaymenCode
                                       };
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["customer_id"].Visible = false;
            this.dataGridView1.Sort(dataGridView1.Columns["id"],ListSortDirection.Descending);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                idheader = Convert.ToInt32(r.Cells["id"].Value.ToString());
                tampildg2(db, r);
            }
        }
        private void tampildg2(DataClasses1DataContext db,DataGridViewRow r)
        {
            try
            {
                dataGridView2.DataSource = from a in db.HeaderTransactions
                                           join b in db.DetailTransactions
                                           on a.id equals b.header_transaction_id
                                           where a.id == idheader
                                           select new
                                           {
                                               b.id,
                                               productName = b.Product.name,
                                               productPrice = b.Product.price,
                                               Quantity = b.quantity,
                                               ImageName = b.Product.image_name
                                           };
                dataGridView2.Columns["ImageName"].Visible = false;
                dataGridView2.Columns["id"].Visible = false;
                foreach (DataGridViewRow item in dataGridView2.Rows)
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
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dataGridView2.DataSource = from a in db.HeaderTransactions
                                           join b in db.DetailTransactions
                                           on a.id equals b.header_transaction_id
                                           where a.id == idheader
                                           select new
                                           {
                                               b.id,
                                               productName = b.Product.name,
                                               productPrice = b.Product.price,
                                               Quantity = b.quantity,
                                               ImageName = b.Product.image_name
                                           };
                dataGridView2.Columns["ImageName"].Visible = false;
                dataGridView2.Columns["id"].Visible = false;
                foreach (DataGridViewRow item in dataGridView2.Rows)
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
