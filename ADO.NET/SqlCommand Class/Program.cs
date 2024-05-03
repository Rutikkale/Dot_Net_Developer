using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlCommand_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.connection();
            Console.ReadLine();
        }

        static void connection()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbes"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string query = "select*from employee_tbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
