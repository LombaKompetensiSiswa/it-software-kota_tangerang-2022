namespace LKSMART_03
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pccustomer = new System.Windows.Forms.PictureBox();
            this.lanameatas = new System.Windows.Forms.Label();
            this.laprice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastock = new System.Windows.Forms.Label();
            this.lacategory = new System.Windows.Forms.Label();
            this.laname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.laqty = new System.Windows.Forms.Label();
            this.btnMinn = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(521, 44);
            this.panel1.TabIndex = 3;
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Location = new System.Drawing.Point(477, 0);
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
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADD TO CART";
            // 
            // pccustomer
            // 
            this.pccustomer.Image = ((System.Drawing.Image)(resources.GetObject("pccustomer.Image")));
            this.pccustomer.Location = new System.Drawing.Point(12, 134);
            this.pccustomer.Name = "pccustomer";
            this.pccustomer.Size = new System.Drawing.Size(201, 204);
            this.pccustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pccustomer.TabIndex = 24;
            this.pccustomer.TabStop = false;
            // 
            // lanameatas
            // 
            this.lanameatas.AutoSize = true;
            this.lanameatas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanameatas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lanameatas.Location = new System.Drawing.Point(12, 110);
            this.lanameatas.Name = "lanameatas";
            this.lanameatas.Size = new System.Drawing.Size(61, 21);
            this.lanameatas.TabIndex = 25;
            this.lanameatas.Text = "Name";
            // 
            // laprice
            // 
            this.laprice.AutoSize = true;
            this.laprice.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laprice.Location = new System.Drawing.Point(229, 134);
            this.laprice.Name = "laprice";
            this.laprice.Size = new System.Drawing.Size(56, 21);
            this.laprice.TabIndex = 26;
            this.laprice.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastock);
            this.groupBox1.Controls.Add(this.lacategory);
            this.groupBox1.Controls.Add(this.laname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(220, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 172);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lastock
            // 
            this.lastock.AutoSize = true;
            this.lastock.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastock.Location = new System.Drawing.Point(110, 152);
            this.lastock.Name = "lastock";
            this.lastock.Size = new System.Drawing.Size(13, 17);
            this.lastock.TabIndex = 33;
            this.lastock.Text = "-";
            // 
            // lacategory
            // 
            this.lacategory.AutoSize = true;
            this.lacategory.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lacategory.Location = new System.Drawing.Point(110, 89);
            this.lacategory.Name = "lacategory";
            this.lacategory.Size = new System.Drawing.Size(13, 17);
            this.lacategory.TabIndex = 32;
            this.lacategory.Text = "-";
            // 
            // laname
            // 
            this.laname.AutoSize = true;
            this.laname.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laname.Location = new System.Drawing.Point(110, 28);
            this.laname.Name = "laname";
            this.laname.Size = new System.Drawing.Size(13, 17);
            this.laname.TabIndex = 31;
            this.laname.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(10, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name :";
            // 
            // laqty
            // 
            this.laqty.AutoSize = true;
            this.laqty.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laqty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laqty.Location = new System.Drawing.Point(89, 409);
            this.laqty.Name = "laqty";
            this.laqty.Size = new System.Drawing.Size(13, 17);
            this.laqty.TabIndex = 31;
            this.laqty.Text = "-";
            // 
            // btnMinn
            // 
            this.btnMinn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinn.Location = new System.Drawing.Point(32, 402);
            this.btnMinn.Name = "btnMinn";
            this.btnMinn.Size = new System.Drawing.Size(36, 38);
            this.btnMinn.TabIndex = 32;
            this.btnMinn.Text = "-";
            this.btnMinn.UseVisualStyleBackColor = false;
            this.btnMinn.Click += new System.EventHandler(this.btnMinn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlus.Location = new System.Drawing.Point(124, 402);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(36, 38);
            this.btnPlus.TabIndex = 33;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(220, 464);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 38);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 514);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinn);
            this.Controls.Add(this.laqty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laprice);
            this.Controls.Add(this.lanameatas);
            this.Controls.Add(this.pccustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCart";
            this.Load += new System.EventHandler(this.AddToCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pccustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pccustomer;
        private System.Windows.Forms.Label lanameatas;
        private System.Windows.Forms.Label laprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lastock;
        private System.Windows.Forms.Label lacategory;
        private System.Windows.Forms.Label laname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laqty;
        private System.Windows.Forms.Button btnMinn;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubmit;
    }
}