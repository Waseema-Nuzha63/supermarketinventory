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
    public partial class CategoryFrm : Form
    {
        public CategoryFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\smarket.db.mdf;Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CategoryTbl values('" + CatId.Text + "','" + CatName.Text + "','" + CatDescription.Text + "')";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda=new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds= new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close() ;
        }
        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescription.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatId.Text== "")
                {
                    MessageBox.Show("Select the Category to Delete");
                }
                else
                {
                    con.Open();
                    //string query = ("delete CategoryTbl where CatId=@CatId", con);
                    string query = "delete from CategoryTbl where CatId="+ CatId.Text +"";
                    SqlCommand cmd= new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    
                    con.Close();
                    populate();

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (CatId.Text == "" || CatName.Text == "" || CatDescription.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {


                    con.Open();
                    string query = "update CategoryTbl  set CatName='" + CatName.Text + "',CatDescription='" + CatDescription.Text + "'where CatId='" + CatId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully");
                    con.Close();
                    populate();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
        }
    }
}
