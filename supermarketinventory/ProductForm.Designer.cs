namespace supermarketinventory
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Podeletebtn = new System.Windows.Forms.Button();
            this.Proupdatebtn = new System.Windows.Forms.Button();
            this.Proaddbtn = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Podeletebtn);
            this.panel1.Controls.Add(this.Proupdatebtn);
            this.panel1.Controls.Add(this.Proaddbtn);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(108, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 438);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.refreshbtn.Location = new System.Drawing.Point(521, 66);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(69, 21);
            this.refreshbtn.TabIndex = 15;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(377, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 329);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Podeletebtn
            // 
            this.Podeletebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Podeletebtn.FlatAppearance.BorderSize = 0;
            this.Podeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Podeletebtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Podeletebtn.Location = new System.Drawing.Point(153, 322);
            this.Podeletebtn.Name = "Podeletebtn";
            this.Podeletebtn.Size = new System.Drawing.Size(72, 27);
            this.Podeletebtn.TabIndex = 12;
            this.Podeletebtn.Text = "DELETE";
            this.Podeletebtn.UseVisualStyleBackColor = false;
            this.Podeletebtn.Click += new System.EventHandler(this.Podeletebtn_Click);
            // 
            // Proupdatebtn
            // 
            this.Proupdatebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Proupdatebtn.FlatAppearance.BorderSize = 0;
            this.Proupdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proupdatebtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Proupdatebtn.Location = new System.Drawing.Point(64, 322);
            this.Proupdatebtn.Name = "Proupdatebtn";
            this.Proupdatebtn.Size = new System.Drawing.Size(83, 27);
            this.Proupdatebtn.TabIndex = 11;
            this.Proupdatebtn.Text = "UPDATE";
            this.Proupdatebtn.UseVisualStyleBackColor = false;
            this.Proupdatebtn.Click += new System.EventHandler(this.Proupdatebtn_Click);
            // 
            // Proaddbtn
            // 
            this.Proaddbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Proaddbtn.FlatAppearance.BorderSize = 0;
            this.Proaddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proaddbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Proaddbtn.Location = new System.Drawing.Point(6, 322);
            this.Proaddbtn.Name = "Proaddbtn";
            this.Proaddbtn.Size = new System.Drawing.Size(52, 27);
            this.Proaddbtn.TabIndex = 5;
            this.Proaddbtn.Text = "ADD";
            this.Proaddbtn.UseVisualStyleBackColor = false;
            this.Proaddbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(79, 281);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(138, 21);
            this.CatCb.TabIndex = 10;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CATEGORY";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Location = new System.Drawing.Point(79, 239);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(138, 20);
            this.ProdPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRICE";
            // 
            // ProdQty
            // 
            this.ProdQty.Location = new System.Drawing.Point(79, 196);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(138, 20);
            this.ProdQty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUNTITY";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(79, 141);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(138, 20);
            this.ProdName.TabIndex = 4;
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // ProdId
            // 
            this.ProdId.Location = new System.Drawing.Point(79, 92);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(138, 20);
            this.ProdId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(-1, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.FlatAppearance.BorderSize = 0;
            this.Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Category.Location = new System.Drawing.Point(-1, 222);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(106, 27);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(744, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logoutbtn.Location = new System.Drawing.Point(12, 464);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(69, 21);
            this.logoutbtn.TabIndex = 25;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 522);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Podeletebtn;
        private System.Windows.Forms.Button Proupdatebtn;
        private System.Windows.Forms.Button Proaddbtn;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button logoutbtn;
    }
}