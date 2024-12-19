
using Microsoft.Data.SqlClient;

namespace FirstADOApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestDBConnection();
        }

        public static void TestDBConnection()
        {
            using var conn = new SqlConnection("Server=.;Database=HR;Trusted_Connection=yes;TrustServerCertificate=True;");
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT employee_id, email FROM employees";

            using var reader = cmd.ExecuteReader();
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}");
                }
            }
            // 1. là dùng using thì nó tự gọi close()
            // 2. là dùng kiểu try catch xong close()
            //reader.Close();
            conn.Close();
        }
    }
}
