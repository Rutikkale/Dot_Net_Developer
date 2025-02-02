﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataSet_Ado_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbes"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                string emp_query = "Select*From employee_tbl";
                string stu_query = "Select*From student_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(emp_query,con);
                SqlDataAdapter sda2 = new SqlDataAdapter(stu_query,con);
                DataTable employees  = new DataTable();
                DataTable students = new DataTable();
                sda1.Fill(employees);
                sda2.Fill(students);
                DataSet ds = new DataSet();

                ds.Tables.Add(employees);
                ds.Tables.Add(students);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);
                }

                Console.WriteLine("---------------------------------------------------");

                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
                }


                //string query = "spGetEmployees";
                //SqlDataAdapter sda = new SqlDataAdapter(query,con);
                //sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //ds.Tables[0].TableName = "employee_tbl";
                //ds.Tables[1].TableName = "Student_tbl";

                //foreach(DataRow row in ds.Tables["employee_tbl"].Rows)
                //{
                //    Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5] );
                //}

                //Console.WriteLine("---------------------------------------------------");

                //foreach (DataRow row in ds.Tables["student_tbl"].Rows)
                //{
                //    Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
                //}
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
