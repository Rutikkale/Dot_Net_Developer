using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ado_Net_Data_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataTable employee = new DataTable("employee");

                DataColumn id = new DataColumn("id");
                id.Caption = "Emp_Id";
                // id.DataType = typeof(int);
                id.DataType = System.Type.GetType("System.Int32");
                id.AllowDBNull = false;
                id.AutoIncrement = true;
                id.AutoIncrementSeed = 10;
                id.AutoIncrementStep = 10;
                employee.Columns.Add(id);


                /*DataColumn id = new DataColumn("id")
                {
                    Caption = "Emp_Id",
                    // id.DataType = typeof(int);
                    DataType = System.Type.GetType("System.Int32"),
                    AllowDBNull = true
                };
               
                employee.Columns.Add(id);
                */

                DataColumn name = new DataColumn("name");
                name.Caption = "Emp_Name";
                name.DataType = typeof(string);
                name.AllowDBNull = true;
                name.MaxLength = 50;
                name.DefaultValue = "Anonymous";
                name.Unique = true;
                employee.Columns.Add(name);

                DataColumn gender = new DataColumn("gender");
                gender.Caption = "Emp_Gender";
                gender.DataType = typeof(string);
                gender.AllowDBNull = true;
                gender.MaxLength = 50;
                employee.Columns.Add(gender);

                DataRow Raw1 = employee.NewRow();
               // Raw1[id] = 1;
               // Raw1[name] = "Rutik";
                Raw1[gender] = "Male";
                employee.Rows.Add(Raw1);

                employee.Rows.Add(null, "Arpit", "Male");
                employee.Rows.Add(null, "Pritam", "Male");
                employee.Rows.Add(null, "Pranali", "FeMale");
                employee.Rows.Add(null, "Radha", "FeMale");

                employee.PrimaryKey = new DataColumn[] {id};

                foreach( DataRow row in employee.Rows)
                {
                    Console.WriteLine(row["id"] + " " + row["name"] + " " + row[gender] );
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
