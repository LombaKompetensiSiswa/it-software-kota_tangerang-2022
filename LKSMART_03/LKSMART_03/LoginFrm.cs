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
    public partial class LoginFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "| Phone Number / Email")
            {
                tbPhone.Clear();
                tbPhone.ForeColor = Color.Black;
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Text = "| Phone Number / Email";
                tbPhone.ForeColor = Color.Gray;
            }
        }

        private void tbPIN_Enter(object sender, EventArgs e)
        {
            if (tbPIN.Text == "| PIN Number")
            {
                tbPIN.Clear();
                tbPIN.ForeColor = Color.Black;
            }
        }

        private void tbPIN_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPIN.Text = "| PIN Number";
                tbPIN.ForeColor = Color.Gray;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want exit this Application?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPhone.Text =="| Phone Number / Email" || tbPIN.Text == "| PIN Number" || tbPhone.Text == "" || tbPIN.Text == "")
            {
                Helper.showMessage("Your data is not valid,Please try again!");
            }
            else
            {
                cs = db.Customers.Where(s => (s.email == tbPhone.Text || s.phone_number == tbPhone.Text) && s.pin_number == tbPIN.Text).FirstOrDefault();
                if (cs != null)
                {
                    if (cs.deleted_at != null)
                    {
                        Helper.showMessage("Your account has been deleted!");
                    }
                    else if ((cs.email == tbPhone.Text || cs.phone_number == tbPhone.Text) && cs.pin_number == tbPIN.Text)
                    {
                        this.Hide();
                        new MainFrm(cs).Show();
                    }
                    else
                    {
                        Helper.showMessage("Your data is not valid,Please try again!");
                    }
                }
                else
                {
                    Helper.showMessage("Your data is not valid,Please try again!");
                }
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
