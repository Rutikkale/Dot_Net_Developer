using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SQLConnectionADO
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
            string cs = "Data Source =LAPTOP-0BJDO9D1\\SQLEXPRESS ; Initial Catalog = Ado_db; Integrated Security = true;";

           // string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

            // 1) 

            //SqlConnection con =new SqlConnection(cs);

            //try
            //{ 
            //con.Open();
            //if(con.State == ConnectionState.Open)
            //{
            //    Console.WriteLine("Connection has been Created Successfully.");
            //}
            //}
            //catch(SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}

            //2) Use Using Block

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("connection has been Created successfully");
                }
            }


            //3) using Block with try catch


            //SqlConnection conn = null;

            //try
            //{
            //    using (conn = new SqlConnection(cs))
            //    {
            //        conn.Open();
            //        if (conn.State == ConnectionState.Open)
            //        {
            //            Console.WriteLine("Connection has been Created successfully");
            //        }
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}





        }

    }
}
