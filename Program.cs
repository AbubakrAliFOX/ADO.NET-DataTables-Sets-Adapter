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

            int numberOfEmployees = Employees.Rows.Count;
            double totalSalaries = Convert.ToDouble(Employees.Compute("SUM(Salary)", string.Empty));
            double avgSalaries = Convert.ToDouble(Employees.Compute("AVG(Salary)", string.Empty));

            /*Console.WriteLine($" Employees Count: {numberOfEmployees}");
            Console.WriteLine($"Total Salaryies: {totalSalaries}");
            Console.WriteLine($"Average Salaryies: {avgSalaries}");*/

            string filterCondition = "ID = 1";

            DataRow[] resultsRow = Employees.Select(filterCondition);

            foreach (DataRow row in resultsRow)
            {
                row["Name"] = "Kaka";
            }

            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}");
            }
        }
    }
}
