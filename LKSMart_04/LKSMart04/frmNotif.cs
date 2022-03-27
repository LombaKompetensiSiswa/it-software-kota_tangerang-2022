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
    public partial class frmNotif : Form
    {
        Customer cs;
        public frmNotif(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void frmNotif_Load(object sender, EventArgs e)
        {
            laNotif.Text = $"Your order has been submitted successfully. \r\n Please continue the payment process in your \r\n {Helper.namePayment} application.";
            textBox2.Text = Helper.code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }
    }
}
