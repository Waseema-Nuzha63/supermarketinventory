namespace supermarketinventory
{
    partial class SellerForm
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
            this.Spass = new System.Windows.Forms.TextBox();
            this.sellerdataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Sphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Spass);
            this.panel1.Controls.Add(this.sellerdataGridView1);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Sphone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Sage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Sname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Sid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 438);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Spass
            // 
            this.Spass.Location = new System.Drawing.Point(79, 281);
            this.Spass.Name = "Spass";
            this.Spass.Size = new System.Drawing.Size(138, 20);
            this.Spass.TabIndex = 14;
            // 
            // sellerdataGridView1
            // 
            this.sellerdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerdataGridView1.Location = new System.Drawing.Point(237, 80);
            this.sellerdataGridView1.Name = "sellerdataGridView1";
            this.sellerdataGridView1.Size = new System.Drawing.Size(405, 269);
            this.sellerdataGridView1.TabIndex = 13;
            this.sellerdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerdataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.deletebtn.Location = new System.Drawing.Point(153, 322);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(72, 27);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.updatebtn.Location = new System.Drawing.Point(64, 322);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(83, 27);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addbtn.Location = new System.Drawing.Point(6, 322);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(52, 27);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "PASSWORD";
            // 
            // Sphone
            // 
            this.Sphone.Location = new System.Drawing.Point(79, 239);
            this.Sphone.Name = "Sphone";
            this.Sphone.Size = new System.Drawing.Size(138, 20);
            this.Sphone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // Sage
            // 
            this.Sage.Location = new System.Drawing.Point(79, 196);
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(138, 20);
            this.Sage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "AGE";
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(79, 141);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(138, 20);
            this.Sname.TabIndex = 4;
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
            // Sid
            // 
            this.Sid.Location = new System.Drawing.Point(79, 92);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(138, 20);
            this.Sid.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLERS";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(753, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Category
            // 
            this.Category.FlatAppearance.BorderSize = 0;
            this.Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Category.Location = new System.Drawing.Point(12, 247);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(106, 27);
            this.Category.TabIndex = 7;
            this.Category.Text = "Categories";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.logoutbtn.Location = new System.Drawing.Point(32, 480);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(69, 21);
            this.logoutbtn.TabIndex = 27;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sellerdataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Spass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutbtn;
    }
}