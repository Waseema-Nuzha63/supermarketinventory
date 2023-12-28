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

namespace supermarketinventory
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\smarket.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTbl values('" + ProdId.Text + "','" + ProdName.Text + "','" + ProdQty.Text + "',"+ProdPrice.Text+",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product  Added Successfully");
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
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillcombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl",con);
            SqlDataReader rdr;
            rdr=cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("CatName",typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource= dt;
            comboBox2.ValueMember = "CatName";
            comboBox2.DataSource = dt;
            con.Close();
            
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            CategoryFrm cat=new CategoryFrm();
            cat.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Proupdatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {


                    con.Open();
                    string query = "update ProductTbl  set ProdName='" + ProdName.Text + "',ProdQty='" + ProdQty.Text + "'where ProdId='" + ProdId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Podeletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select the product to Delete");
                }
                else
                {
                    con.Open();
                    //string query = ("delete CategoryTbl where CatId=@CatId", con);
                    string query = "delete from ProductTbl where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product Deleted Successfully");

                    con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from ProductTbl where ProdCat='" + comboBox2.SelectedValue + "'";
            SqlDataAdapter sda=new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.ShowDialog();
        }
    }
}
