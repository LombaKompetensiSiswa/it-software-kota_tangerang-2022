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
    public partial class frmTransaksiHistory : Form
    {
        Customer cs;
        public frmTransaksiHistory(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }
        int idHeader;
        private void frmTransaksiHistory_Load(object sender, EventArgs e)
        {
            dataGridView2.ColumnHeadersVisible = false;
            tampil();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void tampil()
        {
            try
            {
                dataGridView1.DataSource = from a in db.HeaderTransactions
                                           join b in db.PointHistories
                                           on a.id equals b.header_transaction_id
                                           where a.customer_id == cs.id
                                           select new
                                           {
                                               a.id,
                                               Date = a.datetime,
                                               TotalPayment = a.sub_total,
                                               PointGained = b.point_gained,
                                               PointDeducated = b.point_deducted,
                                               PaymentCode = a.payment_code,

                                           };
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    idHeader = Convert.ToInt32(row.Cells[0].Value);
                    dataGridView2.ColumnHeadersVisible = true;
                    dataGridView2.DataSource = from a in db.DetailTransactions
                                               join b in db.HeaderTransactions
                                               on a.header_transaction_id equals b.id
                                               where a.header_transaction_id == idHeader
                                               select new
                                               {
                                                   ProductName = a.Product.name,
                                                   ProductPrice = a.Product.price,
                                                   Quantity = a.quantity,
                                                   a.Product.image_name
                                               };
                    foreach (DataGridViewRow r in dataGridView2.Rows)
                    {
                        if (!string.IsNullOrEmpty(r.Cells[4].Value.ToString()) && r.Cells[4].Value.ToString() != null && r.Cells[4].Value.ToString() != "null" && r.Cells[4].Value.ToString() != "")
                        {
                            var path = r.Cells[4].Value.ToString();
                            r.Cells[0].Value = Image.FromFile(Helper.GetProduct(path));
                        }
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
