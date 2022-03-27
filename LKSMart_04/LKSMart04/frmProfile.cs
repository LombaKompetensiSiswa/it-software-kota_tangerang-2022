using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart04
{
    public partial class frmProfile : Form
    {
        Customer cs;
        string NameFile, ImageFile;
        public frmProfile(Customer cus)
        {
            cs = db.Customers.Where(s => s.id == cus.id).FirstOrDefault();
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain(cs).Show();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            disable();
            tampil();
        }

        private void tampil()
        {
            tbName.Text = cs.name;
            tbPhone.Text = cs.phone_number;
            tbEmail.Text = cs.email;
            tbPIN.Text = cs.pin_number;
            tbDate.Text = cs.date_of_birth.ToString(); ;
            tbAddress.Text = cs.address;
            comboBox1.SelectedItem = cs.gender;
            if (!string.IsNullOrEmpty(cs.profile_image_name))
            {
                picCustomer.Image = Image.FromFile(Helper.GetProfile(cs.profile_image_name));
            }
        }

        private void disable()
        {
            tbName.Enabled = false;
            tbPhone.Enabled = false;
            tbEmail.Enabled = false;
            tbPIN.Enabled = false;
            tbDate.Enabled = false;
            tbAddress.Enabled = false;
            comboBox1.Enabled = false;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbName.Enabled)
                {
                    tbName.Enabled = true;
                }
                else
                {
                    if (tbName.Text == "")
                    {
                        Helper.message("Please enter name");
                    }
                    else
                    {
                        cs.name = tbName.Text;
                        db.SubmitChanges();
                        Helper.message("Successfully edit");
                        tbName.Enabled = false;
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbPIN.Enabled)
                {
                    tbPIN.Enabled = true;
                }
                else
                {
                    if (tbPIN.Text == "")
                    {
                        Helper.message("Please enter PIN");
                    }
                    else if (!Helper.validPIN.IsMatch(tbPIN.Text))
                    {
                        Helper.message("PIN Number must be 6 digit");
                    }
                    else
                    {
                        cs.pin_number = tbPIN.Text;
                        db.SubmitChanges();
                        Helper.message("Successfully edit");
                        tbPIN.Enabled = false;
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbDate.Enabled)
                {
                    tbDate.Enabled = true;
                }
                else
                {
                    if (tbDate.Text == "")
                    {
                        Helper.message("Please enter Date of birth");
                    }
                    else
                    {
                        cs.date_of_birth =Convert.ToDateTime( tbDate.Text);
                        db.SubmitChanges();
                        Helper.message("Successfully edit");
                        tbDate.Enabled = false;
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message("Please input date of birth incorrect format(dd/mm/yyyy)");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbAddress.Enabled)
                {
                    tbAddress.Enabled = true;
                }
                else
                {
                    cs.address = tbAddress.Text;
                    db.SubmitChanges();
                    Helper.message("Successfully edit");
                    tbAddress.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!comboBox1.Enabled)
                {
                    comboBox1.Enabled = true;
                }
                else
                {
                    cs.gender = comboBox1.Text;
                    db.SubmitChanges();
                    Helper.message("Successfully edit");
                    comboBox1.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NameFile))
                {
                    if (NameFile != cs.profile_image_name)
                    {
                        cs.profile_image_name = NameFile;
                        File.Copy(ImageFile, Helper.PathProfile + NameFile);
                        db.SubmitChanges();
                        Helper.message("Successfully change photo profile");
                    }
                }
            }
            catch (Exception x)
            {
                Helper.message(x.Message);
            }
            
        }

        private void tbPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "All image (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        picCustomer.Image = null;
                        picCustomer.BackgroundImage = null;
                        ImageFile = ofd.FileName;
                        NameFile = Path.GetFileName(ImageFile);
                        picCustomer.Image = Image.FromFile(ImageFile);
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
