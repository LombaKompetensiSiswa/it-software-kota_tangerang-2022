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
    public partial class PorfileForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        private SqlDataAdapter adapter;
        private DataSet ds;

        private int _id;
        public PorfileForm(int id)
        {
            this._id = id;
            InitializeComponent();
            gender.Items.Add("Female");
            gender.Items.Add("Male");
            adapter = new SqlDataAdapter("SELECT * FROM Customer WHERE id=@id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", this._id);
            ds = new DataSet();
            adapter.Fill(ds);

            name.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            phonenumber.Text = ds.Tables[0].Rows[0]["phone_number"].ToString();
            email.Text = ds.Tables[0].Rows[0]["email"].ToString();
            pin.Text = ds.Tables[0].Rows[0]["pin_number"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["date_of_birth"]);
            gender.SelectedItem = ds.Tables[0].Rows[0]["gender"];
            try
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\profile_pictures\" +
                        (ds.Tables[0].Rows[0]["profile_image_name"].ToString()) + ".png");
            }catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string[] filename = openFileDialog1.FileName.Split('\\', '.');
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET profile_image_name=@image, last_updated_at=@date WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", this._id);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@image", filename[filename.Length - 2]);
                cmd.ExecuteNonQuery();
                conn.Close();
                pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Soal IT Software LKS Kota Tangerang 2022\Soal IT Software LKS Kota Tangerang 2022\images\profile_pictures\" +
                        filename[filename.Length - 2] + ".png");
            }catch
            {
            }
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            if (name.Enabled == false)
            {
                name.Enabled = true;
            }
            else
            {
                if (name.Text.Length > 0)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET name=@name, last_updated_at=@date WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    name.Enabled = false;
                    conn.Close();
                }
            }
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            if (pin.Enabled == false)
            {
                pin.Enabled = true;
            }
            else
            {
                if (pin.Text.Length == 6)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET pin_number=@pin, last_updated_at=@date WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.Parameters.AddWithValue("@pin", pin.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery ();
                    pin.Enabled = false;
                    conn.Close ();
                }
            }
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Enabled == false)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                if (dateTimePicker1.Value != null)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET date_of_birth=@bday, last_updated_at=@date WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", this._id);
                    cmd.Parameters.AddWithValue("@bday", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    dateTimePicker1.Enabled=false;
                    conn.Close();
                }
            }
        }

        private void edit4_Click(object sender, EventArgs e)
        {
            if (address.Enabled == false)
            {
                address.Enabled = true;
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET address=@address, last_updated_at=@date WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", this._id);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();
                address.Enabled=false;
                conn.Close();
            }
        }

        private void edit5_Click(object sender, EventArgs e)
        {
            if (gender.Enabled == false)
            {
                gender.Enabled = true;
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET gender=@gender, last_updated_at=@date WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", this._id);
                cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                gender.Enabled=false;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void pin_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(pin.Text, "^[0-9]+$") && pin.Text.Length > 0)
            {
                pin.Text = pin.Text.Substring(0, pin.Text.Length - 1);
                pin.SelectionStart = pin.Text.Length;
                pin.SelectionLength = 0;
            }
        }
    }
}
