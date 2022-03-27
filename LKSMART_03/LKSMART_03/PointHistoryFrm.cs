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
    public partial class PointHistoryFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        public PointHistoryFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void PointHistoryFrm_Load(object sender, EventArgs e)
        {
            cs = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
            lblPoint.Text = cs.point.ToString();
            tampil();
        }

        private void tampil()
        {
            try
            {
                dataGridView1.DataSource = from a in db.HeaderTransactions
                                           join b in db.PointHistories
                                           on a.id equals b.header_transaction_id
                                           select new
                                           {
                                               b.id,
                                               date = b.created_at,
                                               PaymentCode = a.payment_code,
                                               PointGain = b.point_gained,
                                               PointBefore = b.point_before,
                                               PointAfter = b.point_after,
                                           };
                dataGridView1.Columns["id"].Visible = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["PointGain"].Value.ToString()) == 0)
                    {
                        item.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        item.DefaultCellStyle.BackColor = Color.Green;

                    }
                }
            } 
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tampil();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
