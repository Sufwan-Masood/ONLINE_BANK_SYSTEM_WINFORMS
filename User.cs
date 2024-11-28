using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_bank
{
    public class User : Person
    {
        public decimal Balance { get;  set; } // User's account balance
        public bool IsAdmin { get; private set; }   // Indicates if the user is an admin

        //private readonly DatabaseHelper dbHelper;  // Aggregated DatabaseHelper

        public User(int id, string firstName, string lastName, string email, string DOB,string contact, string iban, string password, decimal balance, bool isAdmin/*, DatabaseHelper db*/)
            : base(id, firstName, lastName, email,DOB, contact, iban, password)
        {
            Balance = balance;
            IsAdmin = isAdmin;
            //dbHelper = db;
        }

        //public bool Authenticate(string username, string password)
        //{
        //    string query = $"SELECT * FROM Users WHERE Email='{username}' AND Password='{password}'";
        //    var result = dbHelper.GetData(query);

        //    if (result.Rows.Count == 1)
        //    {
        //        // Populate user details if authenticated
        //        var userRow = result.Rows[0];
        //        ID = (int)userRow["UserID"];
        //        FirstName = (string)userRow["FirstName"];
        //        LastName = (string)userRow["LastName"];
        //        Email = (string)userRow["Email"];
        //        Contact = (string)userRow["Contact"];
        //        IBAN = (string)userRow["IBAN"];
        //        Password = (string)userRow["Password"];
        //        Balance = (decimal)userRow["Balance"];
        //        IsAdmin = (bool)userRow["IsAdmin"];

        //        SessionManager.CurrentUser = this;
        //        return true;
        //    }
        //    return false;
        //}
        public static bool Authenticate(string username, string password)
        {
            string query = $"SELECT * FROM Users WHERE Email='{username}' AND Password='{password}'";
            var result = DatabaseHelper.DB_Authenticate(query);

            if (result.Rows.Count == 1)
            {
                var userRow = result.Rows[0];
                SessionManager.CurrentUser= new User(
                                                      (int)userRow["UserID"],
                                                      (string)userRow["FirstName"],
                                                      (string)userRow["LastName"],
                                                      (string)userRow["Email"],
                                                      (string)userRow["DOB"],
                                                      (string)userRow["Contact"],
                                                      (string)userRow["IBAN"],
                                                      (string)userRow["Password"],
                                                      (decimal)userRow["Balance"],
                                                      (bool)userRow["IsAdmin"]);
                return true;
             
                
            }
            return false; // User not found
        }
    
        //public static User Authenticate(string username, string password, DatabaseHelper dbHelper)
        //{
        //    string query = $"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'";
        //    DataTable result = dbHelper.GetData(query);

        //    if (result.Rows.Count == 1)
        //    {
        //        var userRow = result.Rows[0];
        //        return new User
        //        {
        //            UserID = (int)userRow["UserID"],
        //            Username = (string)userRow["Username"],
        //            Email = (string)userRow["Email"],
        //            IBAN = (string)userRow["IBAN"],
        //            Balance = (decimal)userRow["Balance"],
        //            IsAdmin = (bool)userRow["IsAdmin"]
        //        };
        //    }
        //    return null; // User not found
        //}
        //public void AddMoney(decimal amount)
        //{
        //    Balance += amount;
        //    string updateQuery = $"UPDATE Users SET Balance = {Balance} WHERE UserID = {ID}";
        //    dbHelper.ExecuteQuery(updateQuery);
        //}

        //public bool SendMoney(decimal amount, string recipientIban)
        //{
        //    if (Balance >= amount)
        //    {
        //        Balance -= amount;
        //        string updateBalanceQuery = $"UPDATE Users SET Balance = {Balance} WHERE UserID = {ID}";
        //        dbHelper.ExecuteQuery(updateBalanceQuery);

        //        // Log the transaction
        //        string transactionQuery = $"INSERT INTO Transactions (UserID, Amount, TransactionType, RecipientIBAN) VALUES ({ID}, {amount}, 'Withdrawal', '{recipientIban}')";
        //        dbHelper.ExecuteQuery(transactionQuery);

        //        return true;
        //    }
        //    return false; // Insufficient balance
        //}

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Balance: {Balance}");
        }

       public  bool addMoney(decimal amount)
        {
            if(amount < 0){
                return false; //  cannot add -ve amount
            }
            else
            {   string query = $"Update Users Set Balance = Balance + {amount} where IBAN = '{SessionManager.CurrentUser.IBAN}'";
                DatabaseHelper.DB_update(query);
                return true;
            }
        }
        public string admin_getTotalBalance()
        {
            string query = $"select sum(Balance) from Users";
            string balance = DatabaseHelper.DB_getBalance(query).ToString();
            return balance;
        }
        public  string GetTotalDepositsCount()
        {
            string query = "SELECT COUNT(*) FROM Transactions WHERE TransactionType = 'Deposit'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetTotalDepositsAmount()
        {
            string query = "SELECT SUM(Amount) FROM Transactions WHERE TransactionType = 'Deposit'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetAvgDepositsAmount()
        {
            string query = "SELECT AVG(Amount) FROM Transactions WHERE TransactionType = 'Deposit'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetTotalWithdrawsCount()
        {
            string query = "SELECT COUNT(*) FROM Transactions WHERE TransactionType = 'Withdrawal'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetTotalWithdrawalAmount()
        {
            string query = "SELECT SUM(Amount) FROM Transactions WHERE TransactionType = 'Withdrawal'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetAvgWithdrawalAmount()
        {
            string query = "SELECT AVG(Amount) FROM Transactions WHERE TransactionType = 'Withdrawal'";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string largestSingleTransaction()
        {
            string query = "SELECT MAX(Amount) FROM Transactions";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string getActiveAccounts()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Balance > 0";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string getAvgUserBalance()
        {
            string query = "SELECT AVG(Balance) FROM Users";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string mostFreqTransactionType()
        {
            string query = "SELECT TOP 1 TransactionType, COUNT(*) AS Count FROM Transactions GROUP BY TransactionType ORDER BY Count DESC";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0";
        }
        public string GetAverageTransactionAmount()
        {
            string query = "SELECT AVG(Amount) FROM Transactions";
            return DatabaseHelper.DB_getBalance(query)?.ToString() ?? "0.00";
        }

        // admin user details
        public DataTable admin_getAllUsers()
        {
            string query = $"select * from Users";
            DataTable all_users = DatabaseHelper.getUserData(query);
            return all_users;

        }
        public string admin_getSpecificUserBalance(int id)
        {
            string query = $"Select Balance from Users where UserID = '{id}'";
            return DatabaseHelper.DB_getBalance(query).ToString();
        }
    }
}
