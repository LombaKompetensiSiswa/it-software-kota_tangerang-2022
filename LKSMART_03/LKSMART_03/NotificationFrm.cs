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
    public partial class NotificationFrm : Form
    {
        public NotificationFrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotificationFrm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Helper.paymentCode;
            latype.Text = Helper.paymentType;
        }
    }
}
