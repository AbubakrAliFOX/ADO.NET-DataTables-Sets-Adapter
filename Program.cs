using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO___DataTables___DataSets__DataAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable Employees = new DataTable();

            /* Employees.Columns.Add("ID", typeof(int));
            Employees.Columns.Add("Name", typeof(string));
            Employees.Columns.Add("Salary", typeof(double));
            Employees.Columns.Add("Country", typeof(string)); */

            DataColumn dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "ID";
            dtColoumn.DataType = typeof(int);
            dtColoumn.AutoIncrement = true;
            dtColoumn.ReadOnly = true;
            dtColoumn.Unique = true;
            dtColoumn.AutoIncrementSeed = 1;
            dtColoumn.AutoIncrementStep = 1;
            Employees.Columns.Add(dtColoumn);

            dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "Name";
            dtColoumn.DataType = typeof(string);
            dtColoumn.AutoIncrement = false;
            dtColoumn.ReadOnly = false;
            dtColoumn.Unique = false;
            Employees.Columns.Add(dtColoumn);

            dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "Salary";
            dtColoumn.DataType = typeof(double);
            dtColoumn.AutoIncrement = false;
            dtColoumn.ReadOnly = false;
            dtColoumn.Unique = false;
            Employees.Columns.Add(dtColoumn);

            dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "Country";
            dtColoumn.DataType = typeof(string);
            dtColoumn.AutoIncrement = false;
            dtColoumn.ReadOnly = false;
            dtColoumn.Unique = false;
            Employees.Columns.Add(dtColoumn);

            Employees.Rows.Add(null, "Abubakr Ali", 5000, "Sudan");
            Employees.Rows.Add(null, "Ahmad", 1000, "Jordan");
            Employees.Rows.Add(null, "Khaled", 3000, "Sudan");

            DataTable Departments = new DataTable();

            dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "ID";
            dtColoumn.DataType = typeof(int);
            dtColoumn.AutoIncrement = true;
            dtColoumn.ReadOnly = true;
            dtColoumn.Unique = true;
            dtColoumn.AutoIncrementSeed = 1;
            dtColoumn.AutoIncrementStep = 1;
            Departments.Columns.Add(dtColoumn);

            dtColoumn = new DataColumn();
            dtColoumn.ColumnName = "Name";
            dtColoumn.DataType = typeof(string);
            dtColoumn.AutoIncrement = false;
            dtColoumn.ReadOnly = false;
            dtColoumn.Unique = false;
            Departments.Columns.Add(dtColoumn);

            Departments.Rows.Add(null, "IT");
            Departments.Rows.Add(null, "Health");
            Departments.Rows.Add(null, "R&D");

            
            DataSet dataSet1 = new DataSet();

            dataSet1.Tables.Add(Employees);
            dataSet1.Tables.Add(Departments);

            foreach (DataRow row in dataSet1.Tables[0].Rows)
            {
                Console.WriteLine($"{row["Name"]}, {row["Country"]}");
            }

            foreach (DataRow row in dataSet1.Tables[1].Rows)
            {
                Console.WriteLine($"{row["ID"]}, {row["Name"]}");
            }
        }
    }
}
