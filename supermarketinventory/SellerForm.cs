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
using System.Text.RegularExpressions;

namespace supermarketinventory
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\smarket.db.mdf;Integrated Security=True;Connect Timeout=30");


        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTbl values('" + Sid.Text + "','" + Sname.Text + "','" + Sage.Text + "','" + Sphone.Text + "','"+Spass.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerdataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        
        private void sellerdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = sellerdataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = sellerdataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Sage.Text = sellerdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = sellerdataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Spass.Text = sellerdataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //sellerdataGridView1.Show();

            //CatCb.SelectedValue = sellerdataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sname.Text == "" || Sid.Text == "" || Sage.Text == ""||Sage.Text==""||Sphone.Text==""||Spass.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {


                    con.Open();
                    string query = "update SellerTbl  set Sname='" + Sname.Text + "',Sage='" + Sage.Text + "',Sphone='"+Sphone.Text+"',Spass='"+Spass.Text+"'where Sid='" + Sid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Select the seller to Delete");
                }
                else
                {
                    con.Open();
                    //string query = ("delete CategoryTbl where CatId=@CatId", con);
                    string query = "delete from SellerTbl where Sid=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");

                    con.Close();
                    populate();
                    /*Sid.Text = "";
                    Sname.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                    Sage.Text = "";*/

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm product=new ProductForm();
            product.ShowDialog();
            this.Hide();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            CategoryFrm category = new CategoryFrm();
            category.ShowDialog();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // private void panel1_Paint(object sender, PaintEventArgs e)
        // {
        //    populate();
        // }
    }
}
