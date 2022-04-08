using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Day35LINQ
{
    internal class LinqToDataTable
    {
        public void AddToTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ProductName");

            dt.Rows.Add("1", "Chai");
            dt.Rows.Add("2", "Coffee");
            dt.Rows.Add("3", "Tofu");
            DisplayProducts(dt);
        }
        public void DisplayProducts(DataTable dt)
        {
            var productName = from DataTable in dt.AsEnumerable() select DataTable.Field<string>("ProductName");
            foreach(string product in productName)
            {
                Console.Write("Product Name :");
                Console.WriteLine(product);
            }
        } 
    }
}
