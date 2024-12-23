using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.IO;

namespace HR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build configuration from appsettings.json
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);
            IConfiguration configuration = builder.Build();

            // Get the connection string from configuration
            using var conn = new SqlConnection(configuration.GetConnectionString("HRDB"));

            // Open the connection
            conn.Open();

            var trans = conn.BeginTransaction();


            // Perform database operations
            //ListCountries(conn);
            //DisplayCountryCount(conn);

            CreateEmployee(
                "Nguyen",
                "Trans 3",
                "nguyena@gmail.com",
                "09012345678",
                DateTime.Today,
                9,
                10000,
                100,
                6,
                conn, trans
            );

            CreateEmployee(
               "Nguyen",
               "Trans 4",
               "nguyena@gmail.com",
               "09012345678",
               DateTime.Today,
               9,
               10000,
               100,
               6,
               conn, trans
           );

            trans.Rollback();

            // Close the connection
            conn.Close();
        }

        private static void DisplayCountryCount(SqlConnection conn)
        {
            var cmd = new SqlCommand("SELECT COUNT(*) FROM countries", conn);
            int c = (int)cmd.ExecuteScalar();
            Console.WriteLine($"Total: {c} rows");
        }

        private static void ListCountries(SqlConnection conn)
        {
            var cmd = new SqlCommand("SELECT * FROM countries", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader[0]}, Name: {reader.GetString(1)}");
            }
        }

        private static int CreateEmployee(
            string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, int jobId,
            double salary, int managerId, int departmentId, SqlConnection conn, SqlTransaction trans
            )
        {
            var cmd = new SqlCommand(@"INSERT INTO employees(
                first_name,
                last_name,
                email,
                phone_number,
                hire_date,
                job_id,
                salary,
                manager_id,
                department_id
                ) VALUES (
                    @first_name,
                    @last_name,
                    @email,
                    @phone_number,
                    @hire_date,
                    @job_id,
                    @salary,
                    @manager_id,
                    @department_id
                )", conn, trans);
            cmd.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 20)).Value = firstName;
            cmd.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 25)).Value = lastName;
            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100)).Value = email;
            cmd.Parameters.Add(new SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 20)).Value = phoneNumber;
            cmd.Parameters.Add(new SqlParameter("@hire_date", System.Data.SqlDbType.Date)).Value = hireDate;
            cmd.Parameters.Add(new SqlParameter("@job_id", System.Data.SqlDbType.Int)).Value = jobId;
            cmd.Parameters.Add(new SqlParameter("@salary", System.Data.SqlDbType.Decimal)).Value = salary;
            cmd.Parameters.Add(new SqlParameter("@department_id", System.Data.SqlDbType.Int)).Value = departmentId;
            cmd.Parameters.Add(new SqlParameter("@manager_id", System.Data.SqlDbType.Int)).Value = managerId;

            var result = cmd.ExecuteNonQuery();
            return result;
        }
    }
}