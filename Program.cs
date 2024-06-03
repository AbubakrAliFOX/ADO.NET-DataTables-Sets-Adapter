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

            Employees.Columns.Add("ID", typeof(int));
            Employees.Columns.Add("Name", typeof(string));
            Employees.Columns.Add("Salary", typeof(double));
            Employees.Columns.Add("Country", typeof(string));

            Employees.Rows.Add("1", "Abubakr Ali", 5000, "Sudan");
            Employees.Rows.Add("2", "Ahmad", 1000, "Jordan");
            Employees.Rows.Add("3", "Khaled", 3000, "Sudan");

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
                row.Delete();
            }

            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}");
            }
        }
    }
}
