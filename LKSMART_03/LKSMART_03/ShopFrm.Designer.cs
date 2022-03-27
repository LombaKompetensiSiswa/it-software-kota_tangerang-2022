namespace LKSMART_03
{
    partial class ShopFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbmax = new System.Windows.Forms.TextBox();
            this.llall = new System.Windows.Forms.LinkLabel();
            this.llmakmin = new System.Windows.Forms.LinkLabel();
            this.llkeripik = new System.Windows.Forms.LinkLabel();
            this.llbiswaf = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IMAGES = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.llkacang = new System.Windows.Forms.LinkLabel();
            this.llcokelat = new System.Windows.Forms.LinkLabel();
            this.llAirMin = new System.Windows.Forms.LinkLabel();
            this.llmikem = new System.Windows.Forms.LinkLabel();
            this.llnuget = new System.Windows.Forms.LinkLabel();
            this.llpulpen = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Location = new System.Drawing.Point(694, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(106, 42);
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
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price Range";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(143, 106);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(130, 20);
            this.tbMin.TabIndex = 8;
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(7, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(781, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbmax
            // 
            this.tbmax.Location = new System.Drawing.Point(312, 106);
            this.tbmax.Name = "tbmax";
            this.tbmax.Size = new System.Drawing.Size(130, 20);
            this.tbmax.TabIndex = 11;
            this.tbmax.TextChanged += new System.EventHandler(this.tbmax_TextChanged);
            // 
            // llall
            // 
            this.llall.AutoSize = true;
            this.llall.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llall.Location = new System.Drawing.Point(7, 145);
            this.llall.Name = "llall";
            this.llall.Size = new System.Drawing.Size(30, 13);
            this.llall.TabIndex = 12;
            this.llall.TabStop = true;
            this.llall.Text = "All>>";
            this.llall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llall_LinkClicked);
            // 
            // llmakmin
            // 
            this.llmakmin.AutoSize = true;
            this.llmakmin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llmakmin.Location = new System.Drawing.Point(44, 145);
            this.llmakmin.Name = "llmakmin";
            this.llmakmin.Size = new System.Drawing.Size(131, 13);
            this.llmakmin.TabIndex = 13;
            this.llmakmin.TabStop = true;
            this.llmakmin.Text = "Makanan dan Minuman>>";
            this.llmakmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // llkeripik
            // 
            this.llkeripik.AutoSize = true;
            this.llkeripik.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llkeripik.Location = new System.Drawing.Point(181, 145);
            this.llkeripik.Name = "llkeripik";
            this.llkeripik.Size = new System.Drawing.Size(51, 13);
            this.llkeripik.TabIndex = 14;
            this.llkeripik.TabStop = true;
            this.llkeripik.Text = "Keripik>>";
            this.llkeripik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkeripik_LinkClicked);
            // 
            // llbiswaf
            // 
            this.llbiswaf.AutoSize = true;
            this.llbiswaf.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbiswaf.Location = new System.Drawing.Point(234, 145);
            this.llbiswaf.Name = "llbiswaf";
            this.llbiswaf.Size = new System.Drawing.Size(103, 13);
            this.llbiswaf.TabIndex = 15;
            this.llbiswaf.TabStop = true;
            this.llbiswaf.Text = "Biskuit dan Wafer>>";
            this.llbiswaf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbiswaf_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMAGES,
            this.AddToCart});
            this.dataGridView1.Location = new System.Drawing.Point(7, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(781, 401);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // IMAGES
            // 
            this.IMAGES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IMAGES.HeaderText = "IMAGES";
            this.IMAGES.Image = ((System.Drawing.Image)(resources.GetObject("IMAGES.Image")));
            this.IMAGES.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGES.Name = "IMAGES";
            this.IMAGES.ReadOnly = true;
            // 
            // AddToCart
            // 
            this.AddToCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddToCart.HeaderText = "AddToCart";
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.ReadOnly = true;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(286, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "-";
            // 
            // llkacang
            // 
            this.llkacang.AutoSize = true;
            this.llkacang.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llkacang.Location = new System.Drawing.Point(339, 145);
            this.llkacang.Name = "llkacang";
            this.llkacang.Size = new System.Drawing.Size(56, 13);
            this.llkacang.TabIndex = 18;
            this.llkacang.TabStop = true;
            this.llkacang.Text = "Kacang>>";
            this.llkacang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkacang_LinkClicked);
            // 
            // llcokelat
            // 
            this.llcokelat.AutoSize = true;
            this.llcokelat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llcokelat.Location = new System.Drawing.Point(398, 145);
            this.llcokelat.Name = "llcokelat";
            this.llcokelat.Size = new System.Drawing.Size(55, 13);
            this.llcokelat.TabIndex = 19;
            this.llcokelat.TabStop = true;
            this.llcokelat.Text = "Cokelat>>";
            this.llcokelat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llcokelat_LinkClicked);
            // 
            // llAirMin
            // 
            this.llAirMin.AutoSize = true;
            this.llAirMin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llAirMin.Location = new System.Drawing.Point(462, 145);
            this.llAirMin.Name = "llAirMin";
            this.llAirMin.Size = new System.Drawing.Size(68, 13);
            this.llAirMin.TabIndex = 20;
            this.llAirMin.TabStop = true;
            this.llAirMin.Text = "Air Mineral>>";
            this.llAirMin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAirMin_LinkClicked);
            // 
            // llmikem
            // 
            this.llmikem.AutoSize = true;
            this.llmikem.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llmikem.Location = new System.Drawing.Point(535, 145);
            this.llmikem.Name = "llmikem";
            this.llmikem.Size = new System.Drawing.Size(109, 13);
            this.llmikem.TabIndex = 21;
            this.llmikem.TabStop = true;
            this.llmikem.Text = "Minuman Kemasan>>";
            this.llmikem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llmikem_LinkClicked);
            // 
            // llnuget
            // 
            this.llnuget.AutoSize = true;
            this.llnuget.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llnuget.Location = new System.Drawing.Point(650, 145);
            this.llnuget.Name = "llnuget";
            this.llnuget.Size = new System.Drawing.Size(54, 13);
            this.llnuget.TabIndex = 22;
            this.llnuget.TabStop = true;
            this.llnuget.Text = "Nugget>>";
            this.llnuget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llnuget_LinkClicked);
            // 
            // llpulpen
            // 
            this.llpulpen.AutoSize = true;
            this.llpulpen.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llpulpen.Location = new System.Drawing.Point(710, 145);
            this.llpulpen.Name = "llpulpen";
            this.llpulpen.Size = new System.Drawing.Size(52, 13);
            this.llpulpen.TabIndex = 23;
            this.llpulpen.TabStop = true;
            this.llpulpen.Text = "Pulpen>>";
            this.llpulpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llpulpen_LinkClicked);
            // 
            // ShopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.llpulpen);
            this.Controls.Add(this.llnuget);
            this.Controls.Add(this.llmikem);
            this.Controls.Add(this.llAirMin);
            this.Controls.Add(this.llcokelat);
            this.Controls.Add(this.llkacang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.llbiswaf);
            this.Controls.Add(this.llkeripik);
            this.Controls.Add(this.llmakmin);
            this.Controls.Add(this.llall);
            this.Controls.Add(this.tbmax);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopFrm";
            this.Load += new System.EventHandler(this.ShopFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbmax;
        private System.Windows.Forms.LinkLabel llall;
        private System.Windows.Forms.LinkLabel llmakmin;
        private System.Windows.Forms.LinkLabel llkeripik;
        private System.Windows.Forms.LinkLabel llbiswaf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn IMAGES;
        private System.Windows.Forms.DataGridViewButtonColumn AddToCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llkacang;
        private System.Windows.Forms.LinkLabel llcokelat;
        private System.Windows.Forms.LinkLabel llAirMin;
        private System.Windows.Forms.LinkLabel llmikem;
        private System.Windows.Forms.LinkLabel llnuget;
        private System.Windows.Forms.LinkLabel llpulpen;
    }
}