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
        //UC 8
        public void AddToTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("IsLike");


            dt.Rows.Add("1", "Chai", "Good", 8, true);
            dt.Rows.Add("2", "Coffee", "Good", 6, true);
            dt.Rows.Add("3", "Green Tea", "Bad", 4, false);
            dt.Rows.Add("4", "Thumbs UP", "Great", 9, true);
            dt.Rows.Add("5", "Montian Dew", "Good", 9, true);
            dt.Rows.Add("6", "Sting", "Bad", 4, false);
            dt.Rows.Add("7", "Maaza", "Very Good", 10, true);
            dt.Rows.Add("8", "Frooti", "Good", 7, true);
            dt.Rows.Add("9", "Sprit", "Bad", 3, false);
            dt.Rows.Add("10", "coco cola", "Great", 10, true);
            dt.Rows.Add("11", "Limca", "Good", 9, true);
            dt.Rows.Add("12", "Bisleri", "Good", 6, true);
            dt.Rows.Add("13", "Slice", "Good", 8, true);
            dt.Rows.Add("14", "Kinley", "Good", 6, true);
            dt.Rows.Add("15", "Kafe Strong", "Good", 7, true);
            dt.Rows.Add("16", "Knock Out", "Great", 9, true);
            dt.Rows.Add("17", "Kafe Lite", "Worst", 2, false);
            dt.Rows.Add("18", "Rum", "Great", 10, true);
            dt.Rows.Add("19", "Whiskey", "Very Good", 10, true);
            dt.Rows.Add("20", "Vodka", "Good", 7, true);
            dt.Rows.Add("21", "Brandi", "Bad", 3, false);
            dt.Rows.Add("22", "Champaine", "Great", 10, true);
            dt.Rows.Add("23", "RedBull", "Good", 9, true);
            dt.Rows.Add("24", "Gluco plus", "Good", 8, true);
            dt.Rows.Add("25", "Red Wine", "Okay", 6, true);

            //    DisplayProducts(dt);
            Retrieve_ISLike(dt);



        }
        public void DisplayProducts(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                string Id = row["ID"].ToString();
                string Name = row["ProductName"].ToString();
                string Review = row["Review"].ToString();
                string rating = row["Rating"].ToString();
                string ISLike = row["IsLike"].ToString();
                Console.WriteLine("ID :" + Id + ", ProductName : " + Name + ", Review : " + Review + ", Rating : " + rating + ", IsLike : " + ISLike);

            }
        }
        //Uc 9
        public void Retrieve_ISLike(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                bool IsLike = Convert.ToBoolean(row["IsLike"].ToString());
                string Name = row["ProductName"].ToString();
                if (IsLike == true)
                {
                    Console.WriteLine("Prduct Name : "+Name+", IsLike : "+IsLike);
                }
            }

        }

        
    }
}
