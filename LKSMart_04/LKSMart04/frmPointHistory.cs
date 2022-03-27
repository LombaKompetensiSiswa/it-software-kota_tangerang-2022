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
    public partial class frmPointHistory : Form
    {
        Customer cs;
        public frmPointHistory(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }

        private void frmPointHistory_Load(object sender, EventArgs e)
        {
            tampil();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void tampil()
        {
            try
            {
                laPoint.Text = cs.point.ToString();
                dataGridView1.DataSource = from a in db.PointHistories
                                           join b in db.HeaderTransactions
                                           on a.header_transaction_id equals b.id
                                           select new
                                           {
                                               Date = b.datetime,
                                               PaymentCode = b.payment_code,
                                               PointGain = a.point_gained,
                                               PointBefore = a.point_before,
                                               PointAfter = a.point_after,
                                           };
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells[2].Value.ToString() == "0")
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        r.DefaultCellStyle.BackColor = Color.Green;
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
