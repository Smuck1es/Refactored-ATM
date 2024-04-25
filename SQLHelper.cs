using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class SQLHelper
    {

        public static void UpdateAccountBalance(string AccountType, int NewBalance, string CustomerNumber)
        {
            SqlConnection cnn;
            string ConnetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\white\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            cnn = new SqlConnection(ConnetionString);
            cnn.Open();

            SqlCommand command;
            string sql = "";

            if (AccountType == "savings")
            {
                sql = "UPDATE ATMInfo SET Savings_Balence = @newBalance WHERE Customer_Number = @customerNumber";
            }
            else if (AccountType == "checkings")
            {
                sql = "UPDATE ATMInfo SET Checkings_Balence = @newBalance WHERE Customer_Number = @customerNumber";
            }

            command = new SqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@newBalance", NewBalance);
            command.Parameters.AddWithValue("@customerNumber", CustomerNumber);
            command.ExecuteNonQuery();

            cnn.Close();
        }

        public static string GetCheckingsBalance(string CustomerNumber)
        {
            SqlConnection cnn;
            string ConnetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\white\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            cnn = new SqlConnection(ConnetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output = "";

            sql = "Select Checkings_Balence from ATMInfo Where Customer_Number = @customerNumber";

            command = new SqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@customerNumber", CustomerNumber);
            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                output = dataReader["Checkings_Balence"].ToString();
            }

            dataReader.Close();
            cnn.Close();

            return output;

        }

        public static string GetSavingsBalance(string CustomerNumber)
        {
            SqlConnection cnn;
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\white\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
            cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output = "";

            sql = "Select Savings_Balence from ATMInfo Where Customer_Number = @customerNumber";


            command = new SqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@customerNumber", CustomerNumber);
            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                output = dataReader["Savings_Balence"].ToString();
            }

            dataReader.Close();
            cnn.Close();

            return output;

        }

    }
}
