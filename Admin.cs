using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_bank
{
    public class Admin : Person
    {
        private readonly DatabaseHelper dbHelper; // Aggregated DatabaseHelper

        public Admin(int id, string firstName, string lastName, string email,string dob, string contact, string iban, string password, DatabaseHelper db)
            : base(id, firstName, lastName, email, dob,contact, iban, password)
        {
            dbHelper = db;
        }

        public void ViewAllUsers()
        {
            string query = "SELECT UserID, FirstName, LastName, Email, IBAN, Balance FROM Users";
            DataTable users = dbHelper.GetData(query);

            foreach (DataRow row in users.Rows)
            {
                Console.WriteLine($"ID: {row["UserID"]}, Name: {row["FirstName"]} {row["LastName"]}, Email: {row["Email"]}, IBAN: {row["IBAN"]}, Balance: {row["Balance"]}");
            }
        }

        public void GenerateReports()
        {
            string query = "SELECT SUM(Balance) AS TotalBalance, COUNT(*) AS TotalUsers FROM Users";
            DataTable report = dbHelper.GetData(query);

            if (report.Rows.Count == 1)
            {
                Console.WriteLine($"Total Balance: {report.Rows[0]["TotalBalance"]}");
                Console.WriteLine($"Total Users: {report.Rows[0]["TotalUsers"]}");
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Admin");
        }
    }
}