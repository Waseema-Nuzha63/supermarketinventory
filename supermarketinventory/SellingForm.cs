using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing.Printing;


namespace supermarketinventory
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\smarket.db.mdf;Integrated Security=True;Connect Timeout=30");


        private void populate()
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populatebills()
        {
            con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
      
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdQty.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
           
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            fillcombo();
            SellerName.Text = Form1.Sellername;

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int Grdtotal = 0,n=0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {

                int  total = Convert.ToInt32(ProQty.Text) * Convert.ToInt32(ProdQty.Text);

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProQty.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProQty.Text) * Convert.ToInt32(ProdQty.Text);
                orderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                amtlbl.Text = ""+ Grdtotal;
            }

        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (billid.Text == "")
            {
                MessageBox.Show("Missing Bill Id");

            }
            else
            {


                try
                {
                    con.Open();
                    string query = "insert into BillTbl values('" + billid.Text + "','" + SellerName.Text + "','" + datelbl.Text + "'," + amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order  Added Successfully");
                    con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void billsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Header
            e.Graphics.DrawString("W.N.FOOD CABIN", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 50));

            // Bill Information
            if (billsDGV.SelectedRows.Count > 0)
            {
                e.Graphics.DrawString("Bill Id: " + billsDGV.SelectedRows[0].Cells[0].Value?.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(100, 100));
                e.Graphics.DrawString("Seller Name: " + SellerName.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(100, 120));
                e.Graphics.DrawString("Date: " + datelbl.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(100, 140));
                e.Graphics.DrawString("Total Amount: Rs " + amtlbl.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(100, 160));
            }

            // CodeSpace
            e.Graphics.DrawString("Thank You !", new Font("Century Gothic", 15, FontStyle.Italic), Brushes.Blue, new Point(270, 200));
            e.Graphics.DrawString("Come Again", new Font("Century Gothic", 15, FontStyle.Italic), Brushes.Blue, new Point(270, 230));
        }


        private void refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl where ProdCat='" + comboBox2.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillcombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //CatCb.ValueMember = "CatName";
            //CatCb.DataSource = dt;
            comboBox2.ValueMember = "CatName";
            comboBox2.DataSource = dt;
            con.Close();


        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login=new Form1();
            login.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


