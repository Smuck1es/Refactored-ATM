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

//Unit Testing:
// Unit testing is used to test methods. Unit testing uses multiple tests to check that the method can handle unexpected inputs.
// Unit testings makes sure that the method preform as expected under these different conditions. These test can even ensure that the method throws exceptions when it should.
// With unit testing the quality of the code will increase and the code will have less bugs. It can also allow for updating code and ensuring it still passes unit testing.
namespace ATM
{
    public partial class Account_Info : Form
    {
        private string CustomerNumber;
        // Takes customer number from login form and saves in variable to use for database interactions
        public Account_Info(string CustomerNumber)
        {
            InitializeComponent();
            this.CustomerNumber = CustomerNumber;
        }

       

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            ATM_Login f1 = new ATM_Login();
            f1.Show();
        }


        private void Account_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chk_withdraw_btn_Click(object sender, EventArgs e)
        {
            string AccountType = "checkings";
            int WithdrawAmount = Int32.Parse(chk_bal_txt.Text);
            int CurrentCheckingBalance = Int32.Parse(chkbal_lbl.Text);
            int CurrentSavingsBalance = Int32.Parse(svgbal_lbl.Text);
           

            if (WithdrawAmount > (CurrentCheckingBalance + CurrentSavingsBalance))
            {
                MessageBox.Show("Withdrawal amount exceeds current balance.");
                return; 
            }
            // Pulls from savings account if checkings is emptied and there's more in the savings
            else if (WithdrawAmount > CurrentCheckingBalance)
            { 
                int WithdrawAmountLeft = WithdrawAmount - CurrentCheckingBalance;
                CurrentCheckingBalance = 0;
                CurrentSavingsBalance = CurrentSavingsBalance - WithdrawAmountLeft;

                int SavingsBalance = CurrentSavingsBalance;
                AccountType = "savings";
                SQLHelper.UpdateAccountBalance(AccountType, SavingsBalance, this.CustomerNumber);
                

            }
            else 
            {
                CurrentCheckingBalance = CurrentCheckingBalance - WithdrawAmount;
            }



            int CheckingsBalance = CurrentCheckingBalance;
            string CustomerNumber = this.CustomerNumber;
            SQLHelper.UpdateAccountBalance(AccountType, CheckingsBalance, CustomerNumber);

            UpdateBalanceLabels();
        }

        private void svg_withdraw_btn_Click(object sender, EventArgs e)
        {
            string AccountType = "savings";
            int SavingsBalance = Int32.Parse(svgbal_lbl.Text);
            int WithdrawAmount = Int32.Parse(svg_bal_txt.Text);

            if (WithdrawAmount > SavingsBalance)
            {
                MessageBox.Show("Withdrawal amount exceeds current balance.");
                return; 
            }

            int NewBalance = SavingsBalance - WithdrawAmount;

            int Balance = NewBalance;
            string CustomerNumber = this.CustomerNumber;
            SQLHelper.UpdateAccountBalance( AccountType, Balance, CustomerNumber);

            UpdateBalanceLabels();

        }

        private void Account_Info_Load_1(object sender, EventArgs e)
        {
            UpdateBalanceLabels();
        }

        public void UpdateBalanceLabels()
        {
            string CheckingsBalance = SQLHelper.GetCheckingsBalance(CustomerNumber);
            chkbal_lbl.Text = CheckingsBalance;

            string SavingsBalance = SQLHelper.GetSavingsBalance(CustomerNumber);
            svgbal_lbl.Text = SavingsBalance;
        }

        private void chk_bal_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void transfer_btn_Click(object sender, EventArgs e)
        {
            int TransferAmount = Int32.Parse(amount_txt.Text);
            string SourceAccount = from_txt.Text.ToLower();
            string DestinationAccount = to_txt.Text.ToLower();

            //Transfers funds to appropriate account
            if ((SourceAccount == "savings" || SourceAccount == "checkings") && (DestinationAccount == "savings" || DestinationAccount == "checkings"))
            {
                int SourceBalance = 0;
                int DestinationBalance = 0;

                //Gets balences for checkings and savings
                if (SourceAccount == "savings")
                {
                    SourceBalance = Int32.Parse(SQLHelper.GetSavingsBalance(CustomerNumber));
                }
                else if (SourceAccount == "checkings")
                {
                    SourceBalance = Int32.Parse(SQLHelper.GetCheckingsBalance(CustomerNumber));
                }

                if (DestinationAccount == "savings")
                {
                    DestinationBalance = Int32.Parse(SQLHelper.GetSavingsBalance(CustomerNumber));
                }
                else if (DestinationAccount == "checkings")
                {
                    DestinationBalance = Int32.Parse(SQLHelper.GetCheckingsBalance(CustomerNumber));
                }
                // Transfers funds to correct account and takes from other
                if (SourceBalance >= TransferAmount)
                {                
                    if (SourceAccount == "savings")
                    {
                        SQLHelper.UpdateAccountBalance("savings", SourceBalance - TransferAmount, CustomerNumber);
                    }
                    else if (SourceAccount == "checkings")
                    {
                        SQLHelper.UpdateAccountBalance("checkings", SourceBalance - TransferAmount, CustomerNumber);
                    }
                    
                    if (DestinationAccount == "savings")
                    {
                        SQLHelper.UpdateAccountBalance("savings", DestinationBalance + TransferAmount, CustomerNumber);
                    }
                    else if (DestinationAccount == "checkings")
                    {
                        SQLHelper.UpdateAccountBalance("checkings", DestinationBalance + TransferAmount, CustomerNumber);
                    }

                }
                else
                {
                    MessageBox.Show("Insufficient funds in the source account.");
                }


            }
            else
            {
                MessageBox.Show("Please enter 'savings' or 'checkings'");
                return;

            }
            UpdateBalanceLabels();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
