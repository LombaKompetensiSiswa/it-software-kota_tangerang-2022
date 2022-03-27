namespace LKSMART_03
{
    partial class ProfileFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.pccustomer = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pcname = new System.Windows.Forms.PictureBox();
            this.pcpin = new System.Windows.Forms.PictureBox();
            this.pcdate = new System.Windows.Forms.PictureBox();
            this.pcaddress = new System.Windows.Forms.PictureBox();
            this.pcgender = new System.Windows.Forms.PictureBox();
            this.laname = new System.Windows.Forms.Label();
            this.lapin = new System.Windows.Forms.Label();
            this.ladate = new System.Windows.Forms.Label();
            this.maskdate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Location = new System.Drawing.Point(713, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(87, 42);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "BACK";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROFILE";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(191, 65);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(217, 20);
            this.tbname.TabIndex = 4;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(191, 126);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(217, 20);
            this.tbphone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(191, 185);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(217, 20);
            this.tbemail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "PIN";
            // 
            // tbpin
            // 
            this.tbpin.Location = new System.Drawing.Point(191, 237);
            this.tbpin.Name = "tbpin";
            this.tbpin.Size = new System.Drawing.Size(217, 20);
            this.tbpin.TabIndex = 12;
            this.tbpin.TextChanged += new System.EventHandler(this.tbpin_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(191, 343);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(217, 76);
            this.tbaddress.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Profile Picture";
            // 
            // cbgender
            // 
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(191, 438);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(217, 21);
            this.cbgender.TabIndex = 22;
            // 
            // pccustomer
            // 
            this.pccustomer.Image = ((System.Drawing.Image)(resources.GetObject("pccustomer.Image")));
            this.pccustomer.Location = new System.Drawing.Point(191, 484);
            this.pccustomer.Name = "pccustomer";
            this.pccustomer.Size = new System.Drawing.Size(146, 124);
            this.pccustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pccustomer.TabIndex = 23;
            this.pccustomer.TabStop = false;
            this.pccustomer.Click += new System.EventHandler(this.pccustomer_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpload.Location = new System.Drawing.Point(352, 571);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 37);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "UPLOAD";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pcname
            // 
            this.pcname.Image = ((System.Drawing.Image)(resources.GetObject("pcname.Image")));
            this.pcname.Location = new System.Drawing.Point(445, 51);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(50, 46);
            this.pcname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcname.TabIndex = 25;
            this.pcname.TabStop = false;
            this.pcname.Click += new System.EventHandler(this.pcname_Click);
            // 
            // pcpin
            // 
            this.pcpin.Image = ((System.Drawing.Image)(resources.GetObject("pcpin.Image")));
            this.pcpin.Location = new System.Drawing.Point(445, 227);
            this.pcpin.Name = "pcpin";
            this.pcpin.Size = new System.Drawing.Size(50, 46);
            this.pcpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcpin.TabIndex = 26;
            this.pcpin.TabStop = false;
            this.pcpin.Click += new System.EventHandler(this.pcpin_Click);
            // 
            // pcdate
            // 
            this.pcdate.Image = ((System.Drawing.Image)(resources.GetObject("pcdate.Image")));
            this.pcdate.Location = new System.Drawing.Point(445, 290);
            this.pcdate.Name = "pcdate";
            this.pcdate.Size = new System.Drawing.Size(50, 46);
            this.pcdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcdate.TabIndex = 27;
            this.pcdate.TabStop = false;
            this.pcdate.Click += new System.EventHandler(this.pcdate_Click);
            // 
            // pcaddress
            // 
            this.pcaddress.Image = ((System.Drawing.Image)(resources.GetObject("pcaddress.Image")));
            this.pcaddress.Location = new System.Drawing.Point(445, 352);
            this.pcaddress.Name = "pcaddress";
            this.pcaddress.Size = new System.Drawing.Size(50, 46);
            this.pcaddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcaddress.TabIndex = 28;
            this.pcaddress.TabStop = false;
            this.pcaddress.Click += new System.EventHandler(this.pcaddress_Click);
            // 
            // pcgender
            // 
            this.pcgender.Image = ((System.Drawing.Image)(resources.GetObject("pcgender.Image")));
            this.pcgender.Location = new System.Drawing.Point(445, 428);
            this.pcgender.Name = "pcgender";
            this.pcgender.Size = new System.Drawing.Size(50, 46);
            this.pcgender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcgender.TabIndex = 29;
            this.pcgender.TabStop = false;
            this.pcgender.Click += new System.EventHandler(this.pcgender_Click);
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laname.Location = new System.Drawing.Point(564, 66);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(128, 16);
            this.laname.TabIndex = 30;
            this.laname.Text = "<<Error Message>>";
            // 
            // lapin
            // 
            this.lapin.AutoSize = true;
            this.lapin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lapin.Location = new System.Drawing.Point(564, 242);
            this.lapin.Name = "lapin";
            this.lapin.Size = new System.Drawing.Size(128, 16);
            this.lapin.TabIndex = 31;
            this.lapin.Text = "<<Error Message>>";
            // 
            // ladate
            // 
            this.ladate.AutoSize = true;
            this.ladate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ladate.Location = new System.Drawing.Point(564, 306);
            this.ladate.Name = "ladate";
            this.ladate.Size = new System.Drawing.Size(128, 16);
            this.ladate.TabIndex = 32;
            this.ladate.Text = "<<Error Message>>";
            // 
            // maskdate
            // 
            this.maskdate.Location = new System.Drawing.Point(191, 287);
            this.maskdate.Mask = "00/00/0000";
            this.maskdate.Name = "maskdate";
            this.maskdate.Size = new System.Drawing.Size(217, 20);
            this.maskdate.TabIndex = 33;
            this.maskdate.ValidatingType = typeof(System.DateTime);
            this.maskdate.TextChanged += new System.EventHandler(this.maskdate_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // ProfileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.maskdate);
            this.Controls.Add(this.ladate);
            this.Controls.Add(this.lapin);
            this.Controls.Add(this.laname);
            this.Controls.Add(this.pcgender);
            this.Controls.Add(this.pcaddress);
            this.Controls.Add(this.pcdate);
            this.Controls.Add(this.pcpin);
            this.Controls.Add(this.pcname);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pccustomer);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbpin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileFrm";
            this.Load += new System.EventHandler(this.ProfileFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbpin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.PictureBox pccustomer;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pcname;
        private System.Windows.Forms.PictureBox pcpin;
        private System.Windows.Forms.PictureBox pcdate;
        private System.Windows.Forms.PictureBox pcaddress;
        private System.Windows.Forms.PictureBox pcgender;
        private System.Windows.Forms.Label laname;
        private System.Windows.Forms.Label lapin;
        private System.Windows.Forms.Label ladate;
        private System.Windows.Forms.MaskedTextBox maskdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}