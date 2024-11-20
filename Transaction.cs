using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_bank
{
    public class Transaction
    {
        // Properties corresponding to the Transactions table
        public int TransactionID { get; private set; }
        public int UserID { get; private set; }
        public decimal Amount { get; private set; }
        public string TransactionType { get; private set; }
        public DateTime Date { get; private set; }
        public string RecipientIBAN { get; private set; } // New Field

        public  DatabaseHelper dbHelper; // Aggregated DatabaseHelper

        // Constructor to initialize the DatabaseHelper
        public Transaction(DatabaseHelper db)
        {
            dbHelper = db;
        }

        // Method to create a new transaction (Insert into database)
        public void CreateTransaction(int userId, decimal amount, string transactionType, string recipientIban = null)
        {
            string query = $"INSERT INTO Transactions (UserID, Amount, TransactionType, RecipientIBAN) " +
                           $"VALUES ({userId}, {amount}, '{transactionType}', {(recipientIban == null ? "NULL" : $"'{recipientIban}'")})";
            dbHelper.ExecuteQuery(query);
        }

        // Method to retrieve a user's transaction history
        public DataTable GetTransactionHistory(int userId)
        {
            string query = $"SELECT * FROM Transactions WHERE UserID = {userId} ORDER BY Date DESC";
            return dbHelper.GetData(query);
        }
        // Retrieve deposit history
        public DataTable GetDepositHistory(int userId)
        {
            string query = $"SELECT TransactionID, Amount, RecipientIBAN, Date " +
                           $"FROM Transactions WHERE UserID = {userId} AND TransactionType = 'Deposit' ORDER BY Date DESC";
            return dbHelper.GetData(query);
        }

        // Retrieve withdrawal history
        public DataTable GetWithdrawalHistory(int userId)
        {
            string query = $"SELECT TransactionID, Amount, RecipientIBAN, Date " +
                           $"FROM Transactions WHERE UserID = {userId} AND TransactionType = 'Withdrawal' ORDER BY Date DESC";
            return dbHelper.GetData(query);
        }

        // Optional: Method to fetch details of a specific transaction
        public bool GetTransactionDetails(int transactionId)
        {
            string query = $"SELECT * FROM Transactions WHERE TransactionID = {transactionId}";
            DataTable result = dbHelper.GetData(query);

            if (result.Rows.Count == 1)
            {
                var row = result.Rows[0];
                TransactionID = (int)row["TransactionID"];
                UserID = (int)row["UserID"];
                Amount = (decimal)row["Amount"];
                TransactionType = (string)row["TransactionType"];
                Date = (DateTime)row["Date"];
                return true;
            }
            return false; // Transaction not found
        }
    }
}
