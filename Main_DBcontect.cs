using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Homework_week2
{
    public class Main_DBcontect
    {
        public static void insert(string newID, string Name, string Br, string Col)
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=C#lession; Integrated Security=true";
            string queryString =
                $@" INSERT INTO Homework_week2
                    (ID,Name,Birthday,Color)
                    VALUES
                    (@ID,@Name,@Birthday,@Col)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", newID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Birthday", Br);
                command.Parameters.AddWithValue("@Col", Col);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang " + totalChangeRows + "Rows.");
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        //修
        public static void Updata(string newID, string Name, string Br, string col)
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=C#lession; Integrated Security=true";

            string queryString =
                $@" UPDATE Homework_week2
                    SET Name = @Name, Birthday = @Birthday, Color = @Col
                    WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", newID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Birthday", Br);
                command.Parameters.AddWithValue("@Col", col);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang " + totalChangeRows + "Rows.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //刪
        public static void Delete(string newID)
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=C#lession; Integrated Security=true";

            string queryString =
                $@" DELETE FROM Homework_week2
                    WHERE (ID = @ID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", newID);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total chang " + totalChangeRows + "Rows.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //查
        public static DataTable Read(string col)
        {
            string connectionString =
                   "Data Source=localhost\\SQLExpress;Initial Catalog=C#lession; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM Homework_week2
                    WHERE Color = @Col 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Col", col);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}
