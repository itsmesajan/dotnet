using System;
using System.Data.SqlClient;

class Program
{
  static void Main(string[] args)
  {
    // Connection string to the Bank database
    string connectionString = "Server=YOUR_SERVER_NAME;Database=Bank;Trusted_Connection=True;";

    // Inserting 5 customer records
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
      conn.Open();
      string insertQuery = @"
                INSERT INTO Customer (Account_no, Address, Balance) VALUES 
                (101, 'Kathmandu', 6000),
                (102, 'Pokhara', 4000),
                (103, 'Biratnagar', 8000),
                (104, 'Lalitpur', 2000),
                (105, 'Bhaktapur', 10000)";
      SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
      insertCmd.ExecuteNonQuery();
      Console.WriteLine("5 customer records inserted successfully.");
    }

    // Displaying customers with balance greater than 5000
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
      conn.Open();
      string selectQuery = "SELECT Account_no, Address, Balance FROM Customer WHERE Balance > 5000";
      SqlCommand selectCmd = new SqlCommand(selectQuery, conn);

      using (SqlDataReader reader = selectCmd.ExecuteReader())
      {
        Console.WriteLine("\nCustomers with balance greater than 5000:");
        Console.WriteLine("-------------------------------------------");
        while (reader.Read())
        {
          Console.WriteLine($"Account_no: {reader["Account_no"]}, Address: {reader["Address"]}, Balance: {reader["Balance"]}");
        }
      }
    }
  }
}
