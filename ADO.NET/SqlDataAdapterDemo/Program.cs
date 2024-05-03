using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlDataAdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbes"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("select*from employee_tbl",con);  
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow Raw in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", Raw[0], Raw[1], Raw[2], Raw[3], Raw[4], Raw[5]);
            }

            Console.ReadLine();
        }
    }
}
