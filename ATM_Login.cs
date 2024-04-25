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

namespace ATM
{
    public partial class ATM_Login : Form
    {
        public ATM_Login()
        {
            InitializeComponent();
        }

        private string CustomerNumber = "";
        private void cust_pin_Click(object sender, EventArgs e)
        {

        }

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\white\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        private void atmlog_Click(object sender, EventArgs e)
        {
            
            if (custnum_txt.Text =="" || custpin_txt.Text=="")
            {
                MessageBox.Show("Please provide a Customer Number and PIN");
                return;
            }

            // Checks if number and pin are correct and logs in if they are
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from ATMInfo where Customer_Number=@custnum and PIN=@custpin", con);
                cmd.Parameters.AddWithValue("@custnum", custnum_txt.Text);
                cmd.Parameters.AddWithValue("@custpin", custpin_txt.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful");
                    CustomerNumber = custnum_txt.Text;
                    this.Hide();
                    Account_Info AtmAccount = new Account_Info(CustomerNumber);
                    AtmAccount.Show();
                }
                else 
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

           
        
        }
    }
}
