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

namespace LKSMART_03
{
    public partial class ProfileFrm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        Customer cs;
        OpenFileDialog ofd;
        string filepath, filename;
        public ProfileFrm(Customer cs)
        {
            InitializeComponent();
            this.cs = cs;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainFrm(cs).Show();
        }

        private void ProfileFrm_Load(object sender, EventArgs e)
        {
            try
            {
                disable();
                Visible();
                cs = db.Customers.Where(s => s.id == cs.id).FirstOrDefault();
                tbaddress.Text = cs.address;
                tbname.Text = cs.name;
                tbemail.Text = cs.email;
                tbpin.Text = cs.pin_number;
                tbphone.Text = cs.phone_number;
                cbgender.Text = cs.gender;
                maskdate.Text = cs.date_of_birth.ToString();
                if (!string.IsNullOrWhiteSpace(cs.profile_image_name))
                    pccustomer.Image = Image.FromFile(Helper.GetprofilePictures(cs.profile_image_name));

            }
            catch 
            {
            }
        }

        private void Visible()
        {
            laname.Visible = true;
            ladate.Visible = true;
            lapin.Visible = true;

        }

        private void disable()
        {
            tbaddress.Enabled = false;
            tbemail.Enabled = false;
            tbname.Enabled = false;
            tbphone.Enabled = false;
            tbpin.Enabled = false;
            cbgender.Enabled = false;
            maskdate.Enabled = false;

        }

        private void pcname_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbname.Enabled == false)
                {
                    tbname.Enabled = true;
                }
                else
                {
                    cs.name = tbname.Text;
                    db.SubmitChanges();
                    Helper.showMessage("Success change name!");
                    tbname.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }    
        }

        private void pcpin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbpin.Enabled == false)
                {
                    tbpin.Enabled = true;
                }
                else
                {
                    cs.pin_number = tbpin.Text;
                    db.SubmitChanges();
                    Helper.showMessage("Success change PIN!");
                    tbpin.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void pcdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskdate.Enabled == false)
                {
                    maskdate.Enabled = true;
                }
                else
                {
                    cs.date_of_birth = Convert.ToDateTime(maskdate.Text);
                    db.SubmitChanges();
                    Helper.showMessage("Success change Date!");
                    maskdate.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage("your birt date is not valid format \r\n\r\n Write your birth date format like this [month/day/year]");
            }
            
        }

        private void pcaddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbaddress.Enabled == false)
                {
                    tbaddress.Enabled = true;
                }
                else
                {
                    cs.address = tbaddress.Text;
                    db.SubmitChanges();
                    Helper.showMessage("Success change address!");
                    tbaddress.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }

        }

        private void pcgender_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbgender.Enabled == false)
                {
                    cbgender.Enabled = true;
                }
                else
                {
                    cs.gender = cbgender.Text;
                    db.SubmitChanges();
                    Helper.showMessage("Success change Gender!");
                    cbgender.Enabled = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbname.Text == "")
                {
                    errorProvider1.SetError(tbname, "Name cant be empty!");
                    laname.Text = "Please insert the name First!";
                    pcname.Enabled = false;
                    laname.Visible = true;
                }
                else
                {
                    pcname.Enabled = true;
                    errorProvider1.Clear();
                    laname.Visible = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void tbpin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbpin.Text == "")
                {
                    errorProvider2.SetError(tbpin, "PIN cant be empty!");
                    lapin.Text = "Please insert the PIN First!";
                    pcpin.Enabled = false;
                    lapin.Visible = true;
                }
                else if (tbpin.TextLength != 6)
                {
                    errorProvider2.SetError(tbpin, "PIN length must six digit numerics!");
                    lapin.Text = "PIN length must six digit numerics!";
                    pcpin.Enabled = false;
                    lapin.Visible = true;
                }
                else
                {
                    pcpin.Enabled = true;
                    errorProvider2.Clear();
                    lapin.Visible = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }

        private void maskdate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (maskdate.Text == "  /  /")
                {
                    errorProvider3.SetError(maskdate, "Date cant be empty!");
                    ladate.Text = "Please insert the Date First!";
                    pcdate.Enabled = false;
                    ladate.Visible = true;
                }
                else
                {
                    pcdate.Enabled = true;
                    errorProvider3.Clear();
                    ladate.Visible = false;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage("Your birthdaye format is not valid! ");
            }
        }

        private void pccustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (ofd = new OpenFileDialog() { Filter = "*.jpg; *.png; *.jpeg | *.jpg; *.png; *.jpeg " })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pccustomer.Image = Image.FromFile(ofd.FileName);
                        filepath = ofd.FileName;
                        filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                    }
                }
            }
            catch 
            {
                filename = null;
                filepath = null;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filepath))
                {
                    Helper.showMessage("Please select picture first");
                }
                else
                {
                    Helper.saveFile(filepath, Helper.pathProfile + ofd.SafeFileName, true);
                    cs.profile_image_name = filename;
                    db.SubmitChanges();
                    Helper.showMessage("Success change picture profile!");
                    filename = null;
                    filepath = null;
                }
            }
            catch (Exception x)
            {
                Helper.showMessage(x.Message);
            }
        }
    }
}
