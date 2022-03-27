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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Helper.message("Please enter phone number / email");
            }
            else if (textBox2.Text == "")
            {
                Helper.message("Please enter PIN Number");
            }
            else
            {
                Customer cs = db.Customers.Where(s => (s.email == textBox1.Text || s.phone_number == textBox1.Text) && s.pin_number == textBox2.Text).FirstOrDefault();
                if (cs != null)
                {
                    if (cs.deleted_at == null)
                    {
                        this.Hide();
                        new frmMain(cs).Show();
                    }
                    else
                    {
                        Helper.message("Sorry your acount has been deleted");
                    }
                }
                else
                {
                    Helper.message("Sorry your data is not valid ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5-702-174-1306";
            textBox2.Text = "680660";
        }
    }
}
