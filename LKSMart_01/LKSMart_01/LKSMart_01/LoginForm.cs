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
    public partial class LoginForm : Form
    {
        private int _id;
        public int ID { get { return _id; } }
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1N9H44Q\ITSS;Initial Catalog=LKSMart;Integrated Security=true;");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id FROM Customer WHERE (email=@username OR phone_number=@username) AND pin_number=@pin_number", conn);
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pin_number", PinTextBox.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    _id = reader.GetInt32(0);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    conn.Close();
                }
                else
                {
                    usernameTextBox.Text = string.Empty;
                    PinTextBox.Text = string.Empty;
                    reader.Close();
                    MessageBox.Show("Failed to login email, phone number, or pin is incorrect", "warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void PinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PinTextBox.Text, "^[0-9]+$") && PinTextBox.Text.Length > 0)
            {
                PinTextBox.Text = PinTextBox.Text.Substring(0, PinTextBox.Text.Length - 1);
                PinTextBox.SelectionStart = PinTextBox.Text.Length;
                PinTextBox.SelectionLength = 0;
            }
        }
    }
}
