using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LKSMart_01
{
    public partial class PointForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        private SqlDataAdapter adapter;
        private DataSet ds;
        private DataSet ds1;
        private int _id;
        public PointForm(int id)
        {
            this._id = id;
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM PointHistory JOIN HeaderTransaction ON PointHistory.header_transaction_id=HeaderTransaction.id WHERE PointHistory.customer_id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this._id);
            ds = new DataSet();
            adapter.Fill(ds);
            adapter = new SqlDataAdapter("SELECT point FROM Customer WHERE id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this._id);
            ds1= new DataSet();
            adapter.Fill(ds1);

            label3.Text = ds1.Tables[0].Rows[0]["point"].ToString();

            while (panel1.Controls.Count > 0)
            {
                panel1.Controls[0].Dispose();
            }

            List<Panel> points = new List<Panel>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                points.Add(new Panel());
                Label date = new Label(),
                    paymentCode = new Label(),
                    PointGained = new Label(),
                    PointDeducted = new Label(),
                    PointBefore = new Label(),
                    PointAfter = new Label();

                date.Location = new Point(100, 30);
                paymentCode.Location = new Point(200, 30);
                PointGained.Location = new Point(300, 30);
                PointDeducted.Location = new Point(400, 30);
                PointBefore.Location = new Point(500, 30);
                PointAfter.Location = new Point(600, 30);

                date.Text = ds.Tables[0].Rows[i]["created_at"].ToString();
                paymentCode.Text = ds.Tables[0].Rows[i]["payment_code"].ToString();
                PointGained.Text = ds.Tables[0].Rows[i]["point_gained"].ToString();
                PointDeducted.Text = ds.Tables[0].Rows[i]["point_deducted"].ToString();
                PointBefore.Text = ds.Tables[0].Rows[i]["point_before"].ToString();
                PointAfter.Text = ds.Tables[0].Rows[i]["point_after"].ToString();

                date.AutoSize = true;
                paymentCode.AutoSize = true;
                PointGained.AutoSize = true;
                PointBefore.AutoSize = true;
                PointAfter.AutoSize = true;

                points[i].Width = 755;
                points[i].Height = 80;
                points[i].Location = new Point(10, 10*(i+1) + 80*i);
                points[i].Controls.AddRange(new Control[] {date, paymentCode, PointGained, PointBefore, PointAfter});

            }

            foreach (Panel point in points)
            {
                panel1.Controls.Add(point);
            }
        }

        private void PointForm_Load(object sender, EventArgs e)
        {

        }
    }
}
