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
    }
}
