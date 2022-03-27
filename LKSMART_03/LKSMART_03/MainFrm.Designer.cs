namespace LKSMART_03
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pccustomer = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.pcprofile = new System.Windows.Forms.PictureBox();
            this.pcpoint = new System.Windows.Forms.PictureBox();
            this.pcShop = new System.Windows.Forms.PictureBox();
            this.pctransaction = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pccart = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.Location = new System.Drawing.Point(727, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(44, 44);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "__";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Location = new System.Drawing.Point(771, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(44, 44);
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
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
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAIN FORM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pccart);
            this.panel2.Controls.Add(this.lbldate);
            this.panel2.Controls.Add(this.lbluser);
            this.panel2.Controls.Add(this.pccustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 114);
            this.panel2.TabIndex = 2;
            // 
            // pccustomer
            // 
            this.pccustomer.Image = ((System.Drawing.Image)(resources.GetObject("pccustomer.Image")));
            this.pccustomer.Location = new System.Drawing.Point(13, 3);
            this.pccustomer.Name = "pccustomer";
            this.pccustomer.Size = new System.Drawing.Size(126, 108);
            this.pccustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pccustomer.TabIndex = 0;
            this.pccustomer.TabStop = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(145, 12);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(104, 21);
            this.lbluser.TabIndex = 8;
            this.lbluser.Text = "Hello,User";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.Location = new System.Drawing.Point(145, 90);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(49, 21);
            this.lbldate.TabIndex = 9;
            this.lbldate.Text = "date";
            // 
            // pcprofile
            // 
            this.pcprofile.Image = ((System.Drawing.Image)(resources.GetObject("pcprofile.Image")));
            this.pcprofile.Location = new System.Drawing.Point(89, 219);
            this.pcprofile.Name = "pcprofile";
            this.pcprofile.Size = new System.Drawing.Size(138, 108);
            this.pcprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcprofile.TabIndex = 10;
            this.pcprofile.TabStop = false;
            this.pcprofile.Click += new System.EventHandler(this.pcprofile_Click);
            // 
            // pcpoint
            // 
            this.pcpoint.Image = ((System.Drawing.Image)(resources.GetObject("pcpoint.Image")));
            this.pcpoint.Location = new System.Drawing.Point(89, 412);
            this.pcpoint.Name = "pcpoint";
            this.pcpoint.Size = new System.Drawing.Size(138, 108);
            this.pcpoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcpoint.TabIndex = 11;
            this.pcpoint.TabStop = false;
            this.pcpoint.Click += new System.EventHandler(this.pcpoint_Click);
            // 
            // pcShop
            // 
            this.pcShop.Image = ((System.Drawing.Image)(resources.GetObject("pcShop.Image")));
            this.pcShop.Location = new System.Drawing.Point(338, 219);
            this.pcShop.Name = "pcShop";
            this.pcShop.Size = new System.Drawing.Size(135, 108);
            this.pcShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcShop.TabIndex = 12;
            this.pcShop.TabStop = false;
            this.pcShop.Click += new System.EventHandler(this.pcShop_Click);
            // 
            // pctransaction
            // 
            this.pctransaction.Image = ((System.Drawing.Image)(resources.GetObject("pctransaction.Image")));
            this.pctransaction.Location = new System.Drawing.Point(576, 219);
            this.pctransaction.Name = "pctransaction";
            this.pctransaction.Size = new System.Drawing.Size(138, 108);
            this.pctransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctransaction.TabIndex = 13;
            this.pctransaction.TabStop = false;
            this.pctransaction.Click += new System.EventHandler(this.pctransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(109, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "PROFILE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(368, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "SHOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(572, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "TRANSACTION\r\nHISTORY\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pccart
            // 
            this.pccart.Image = ((System.Drawing.Image)(resources.GetObject("pccart.Image")));
            this.pccart.Location = new System.Drawing.Point(654, 15);
            this.pccart.Name = "pccart";
            this.pccart.Size = new System.Drawing.Size(50, 46);
            this.pccart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pccart.TabIndex = 18;
            this.pccart.TabStop = false;
            this.pccart.Click += new System.EventHandler(this.pccart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(710, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 37);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(85, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "TRANSACTION\r\nHISTORY\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctransaction);
            this.Controls.Add(this.pcShop);
            this.Controls.Add(this.pcpoint);
            this.Controls.Add(this.pcprofile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pccart;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox pccustomer;
        private System.Windows.Forms.PictureBox pcprofile;
        private System.Windows.Forms.PictureBox pcpoint;
        private System.Windows.Forms.PictureBox pcShop;
        private System.Windows.Forms.PictureBox pctransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}