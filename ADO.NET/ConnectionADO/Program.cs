using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ConnectionADO
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
            string cs = "Data Source = LAPTOP-0BJDO9D1\\SQLEXPRESS ; Initial Catalog = Ado_db; Integrated Security = true ";
            SqlConnection conn = null;

            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        Console.WriteLine("connection has been Created Successfully!!");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn?.Close();
            }

        }
    }

}
