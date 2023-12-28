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

namespace supermarketinventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = ""; 
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\smarket.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            uname.Text = "";
            pass.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (uname.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)

                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (uname.Text == "Admin" && pass.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the admin , enter the correct id and password ");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("your in the seller section");
                        con.Open();
                        SqlDataAdapter sda=new SqlDataAdapter("Select count(8) from SellerTbl where Sname='"+uname.Text+ "' and Spass='"+ pass.Text+"'",con);
                        DataTable dt=new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString()=="1")
                        {
                            Sellername=uname.Text;
                            SellingForm sell=new SellingForm();
                            sell.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                        con.Close() ;
                    }

                }
                else
                {
                    MessageBox.Show("Select a Role");
                }


            }
        }




        /* private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
         {

         }*/
    }
}


