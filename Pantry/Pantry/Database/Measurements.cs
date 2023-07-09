using System;
using System.Text;
using System.Data;
using System.Data.SQLite;
namespace Pantry.Database;

internal class Measurements
{
    internal static void CreateConnection()
    {
        string connectionString = "Data Source=/home/zeref/Desktop/Projects/Pantry/Pantry/Pantry/SQLiteDB/Measurements.db";

        
        // Create a new SQLite connection
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Create a table if it doesn't already exist
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Measurements (Ingredient TEXT PRIMARY KEY)";
            using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
            {
                createTableCommand.ExecuteNonQuery();
            }

    
            connection.Close();
        }
        Console.WriteLine("Connected to the database");
    }
}