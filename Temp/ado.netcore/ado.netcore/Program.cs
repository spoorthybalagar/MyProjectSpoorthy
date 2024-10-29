using System.Data;
using System.Data.SqlClient;
using System.IO;
//using Microsoft.Data.SqlClient;

namespace ado.netcore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Server=DESKTOP-GF410M3\\SQLSERVER2022;Database=EmployeeDb;User ID=sa;Password=user123;Trusted_Connection=True;TrustServerCertificate=True;";


                GetAllEmployees(connectionString);
                //calling getemployeebyid
                int EmployeeID = 1;
                GetAllEmployeeID(connectionString, EmployeeID);
                //calling CreateEmployeeWithAddress
                Console.WriteLine("enter the first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("enter the last name");
                string lastName = Console.ReadLine();
                Console.WriteLine("enter the email");
                string email = Console.ReadLine();
                Console.WriteLine("enter street");
                string street = Console.ReadLine();
                Console.WriteLine("enter the city");
                string city = Console.ReadLine();
                Console.WriteLine("enter the state");
                string state = Console.ReadLine();
                Console.WriteLine("enter the postalcode");
                string postalCode = Console.ReadLine();

                CreateEmployeeWithAddress(connectionString, firstName, lastName, email, street, city, state, postalCode);

                //calling UpdateEmployeeWithAddress
                EmployeeID = 1;
                firstName = "Rakesh";
                lastName = "Sharma";
                email = "Rakesh@Example.com";
                street = "3456 Patia";
                city = "CTC";
                state = "India";
                postalCode = "755024";
                int addressID = 3;

                UpdateEmployeeWithAddress(connectionString, EmployeeID, firstName, lastName, email, street, city, state, postalCode, addressID);

                //calling
                EmployeeID = 3;
                DeleteEmployee(connectionString, EmployeeID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong:{ex.Message}");
            }
        }

        static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees Store Procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString))//setting connection 
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection); //GetAllEmployees--> storeprocedure in server
                command.CommandType = CommandType.StoredProcedure;//send request
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())//read the data
                {
                    Console.WriteLine($"EmployeeID: {reader["EmployeeID"]},FirstName:{reader["FirstName"]},LastName:{reader["Lastname"]}, Email: {reader["Email"]}");
                    Console.WriteLine($"Address:{reader["street"]},City:{reader["City"]},States:{reader["States"]},PostalCode:{reader["PostalCode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }


        static void GetAllEmployeeID(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID Stored Procedure Called");
                SqlCommand command = new SqlCommand("GetAllEmployeeID", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee:{reader["FirstName"]}{reader["LastName"]}Email:{reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["States"]},{reader["PostalCode"]}");

                }
                reader.Close();
                connection.Close();
            }
        }


        static void CreateEmployeeWithAddress(string connectionString, string firstName, string lastName, string email, string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("CreateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddresses", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameter for Employee and address
                command.Parameters.AddWithValue("@firstname", firstName);
                command.Parameters.AddWithValue("@lastname", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", state);
                command.Parameters.AddWithValue("@postalcode", postalCode);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully.");
                connection.Close();
            }
        }


        static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstName, string lastName, string email, string street, string city, string state, string postalCode, int addressID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameter for Employee and address
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@firstname", firstName);
                command.Parameters.AddWithValue("@lastname", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", state);
                command.Parameters.AddWithValue("@postalcode", postalCode);
                command.Parameters.AddWithValue("@addressID", addressID);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Addresses updated successfully,");
                connection.Close();

            }
        }

        static void DeleteEmployee(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine(value: "DeleteEmployee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();

            }
        }
    }
}
