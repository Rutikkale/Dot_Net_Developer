using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Copy_Clone_Datatable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbes"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string query = "select*from employee_tbl";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                DataTable employees = new DataTable();
                sda.Fill(employees);


                Console.WriteLine("Origilnal DataTable");
                foreach (DataRow row in employees.Rows)
                {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"] + " " + row["age"] + " " + row["salary"] + " " + row["city"] );
                }

                Console.WriteLine("------------------------");

                DataTable CopyDataTable = employees.Copy();
                Console.WriteLine("Copy DataTable");
                foreach (DataRow row in CopyDataTable.Rows)
                {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"] + " " + row["age"] + " " + row["salary"] + " " + row["city"]);
                }

                Console.WriteLine("------------------------");

                DataTable CloneDataTable = employees.Clone();
                Console.WriteLine("Clone DataTable");
                if (CloneDataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in CloneDataTable.Rows)
                    {
                        Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"] + " " + row["age"] + " " + row["salary"] + " " + row["city"]);
                    }
                }
                else
                {
                    // Console.WriteLine("Rows not found");
                    CloneDataTable.Rows.Add(1, "Dharvesh", "Male", 23, 45000, "Nagpur");
                    CloneDataTable.Rows.Add(2, "Sanket", "Male", 25, 45000, "Yavatmal");
                }
                foreach (DataRow row in CloneDataTable.Rows)
                {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row["gender"] + " " + row["age"] + " " + row["salary"] + " " + row["city"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            
            finally
            {

            }

            Console.ReadLine();
        }
    }
}
