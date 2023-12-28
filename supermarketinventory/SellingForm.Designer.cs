namespace supermarketinventory
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerName = new System.Windows.Forms.Button();
            this.ProQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.billsDGV = new System.Windows.Forms.DataGridView();
            this.printbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logout = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel.Controls.Add(this.label8);
            this.Panel.Controls.Add(this.orderDGV);
            this.Panel.Controls.Add(this.amtlbl);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.SellerName);
            this.Panel.Controls.Add(this.ProQty);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.ProdDGV1);
            this.Panel.Controls.Add(this.refreshbtn);
            this.Panel.Controls.Add(this.comboBox2);
            this.Panel.Controls.Add(this.billsDGV);
            this.Panel.Controls.Add(this.printbtn);
            this.Panel.Controls.Add(this.addbtn);
            this.Panel.Controls.Add(this.ProdQty);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.ProdName);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.billid);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(117, 72);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(680, 451);
            this.Panel.TabIndex = 1;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "SELLS LIST";
            // 
            // orderDGV
            // 
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PName,
            this.ProPrice,
            this.PQty,
            this.Total});
            this.orderDGV.Location = new System.Drawing.Point(243, 35);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.Size = new System.Drawing.Size(425, 136);
            this.orderDGV.TabIndex = 22;
            this.orderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDGV_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Prodid";
            this.id.Name = "id";
            // 
            // PName
            // 
            this.PName.HeaderText = "Prodname";
            this.PName.Name = "PName";
            // 
            // ProPrice
            // 
            this.ProPrice.HeaderText = "Proprice";
            this.ProPrice.Name = "ProPrice";
            // 
            // PQty
            // 
            this.PQty.HeaderText = "ProdQty";
            this.PQty.Name = "PQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // amtlbl
            // 
            this.amtlbl.AutoSize = true;
            this.amtlbl.Location = new System.Drawing.Point(401, 181);
            this.amtlbl.Name = "amtlbl";
            this.amtlbl.Size = new System.Drawing.Size(20, 13);
            this.amtlbl.TabIndex = 21;
            this.amtlbl.Text = "Rs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount Rs:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(115, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SellerName
            // 
            this.SellerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellerName.FlatAppearance.BorderSize = 0;
            this.SellerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SellerName.Location = new System.Drawing.Point(3, 3);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(69, 21);
            this.SellerName.TabIndex = 18;
            this.SellerName.Text = "Seller";
            this.SellerName.UseVisualStyleBackColor = false;
            // 
            // ProQty
            // 
            this.ProQty.Location = new System.Drawing.Point(68, 93);
            this.ProQty.Name = "ProQty";
            this.ProQty.Size = new System.Drawing.Size(138, 20);
            this.ProQty.TabIndex = 18;
            this.ProQty.TextChanged += new System.EventHandler(this.ProQty_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price";
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(6, 207);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.Size = new System.Drawing.Size(237, 241);
            this.ProdDGV1.TabIndex = 16;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.refreshbtn.Location = new System.Drawing.Point(159, 180);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(84, 21);
            this.refreshbtn.TabIndex = 15;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // billsDGV
            // 
            this.billsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDGV.Location = new System.Drawing.Point(255, 233);
            this.billsDGV.Name = "billsDGV";
            this.billsDGV.Size = new System.Drawing.Size(422, 182);
            this.billsDGV.TabIndex = 13;
            this.billsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsDGV_CellContentClick);
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.printbtn.FlatAppearance.BorderSize = 0;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.printbtn.Location = new System.Drawing.Point(585, 421);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(83, 27);
            this.printbtn.TabIndex = 11;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addbtn.Location = new System.Drawing.Point(477, 421);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(85, 27);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.Location = new System.Drawing.Point(68, 119);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(138, 20);
            this.ProdQty.TabIndex = 6;
            this.ProdQty.TextChanged += new System.EventHandler(this.ProdQty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quntity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(68, 69);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(138, 20);
            this.ProdName.TabIndex = 4;
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProdName";
            // 
            // billid
            // 
            this.billid.Location = new System.Drawing.Point(68, 43);
            this.billid.Name = "billid";
            this.billid.Size = new System.Drawing.Size(138, 20);
            this.billid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // datelbl
            // 
            this.datelbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.datelbl.FlatAppearance.BorderSize = 0;
            this.datelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datelbl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.datelbl.Location = new System.Drawing.Point(702, 45);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(86, 21);
            this.datelbl.TabIndex = 16;
            this.datelbl.Text = "Date";
            this.datelbl.UseVisualStyleBackColor = false;
            this.datelbl.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logout.Location = new System.Drawing.Point(29, 499);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(69, 21);
            this.logout.TabIndex = 24;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView billsDGV;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button datelbl;
        private System.Windows.Forms.TextBox ProQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SellerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amtlbl;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button logout;
    }
}