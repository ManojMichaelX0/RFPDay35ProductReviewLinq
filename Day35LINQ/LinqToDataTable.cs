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
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("IsLike");


            dt.Rows.Add(1, "Chai", 1, "Good", 8, true);
            dt.Rows.Add(2, "Coffee", 1, "nice", 6, true);
            dt.Rows.Add(3, "Green Tea", 1, "Bad", 4, false);
            dt.Rows.Add(4, "Thumbs UP", 2, "Great", 9, true);
            dt.Rows.Add(5, "Montian Dew", 2, "Good", 9, true);
            dt.Rows.Add(6, "Sting", 2, "Bad", 4, false);
            dt.Rows.Add(7, "Maaza", 3, "Very Good", 10, true);
            dt.Rows.Add(8, "Frooti", 3, "Good", 7, true);
            dt.Rows.Add(9, "Sprit", 2, "Bad", 3, false);
            dt.Rows.Add(10, "coco cola", 2, "Great", 9, true);
            dt.Rows.Add(11, "Limca", 3, "Good", 9, true);
            dt.Rows.Add(12, "Bisleri", 4, "Good", 6, true);
            dt.Rows.Add(10, "Slice", 3, "Good", 8, true);
            dt.Rows.Add(14, "Kinley", 4, "Good", 6, true);
            dt.Rows.Add(15, "Kafe Strong", 5, "nice", 7, true);
            dt.Rows.Add(16, "Knock Out", 5, "Great", 9, true);
            dt.Rows.Add(10, "Kafe Lite", 5, "Worst", 7, false);
            dt.Rows.Add(10, "Rum", 10, "Great", 6, true);
            dt.Rows.Add(19, "Whiskey", 10, "Very Good", 10, true);
            dt.Rows.Add(20, "Vodka", 10, "nice", 7, true);
            dt.Rows.Add(21, "Brandi", 10, "Bad", 3, false);
            dt.Rows.Add(22, "Champaine", 5, "Great", 10, true);
            dt.Rows.Add(10, "RedBull", 2, "nice", 6, true);
            dt.Rows.Add(24, "Gluco plus", 2, "Good", 8, true);
            dt.Rows.Add(25, "Red Wine", 10, "Okay", 6, true);

            //    DisplayProducts(dt);
            //Uc 9
            //Retrieve_ISLike(dt);

            //Uc 10
            //Retrieve_Avg_Prodructs(dt);

            //UC 11
            //NiceReview(dt);

            //Uc 12
            RatingOrder(dt);
        }
        public void DisplayProducts(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string Id = row["ID"].ToString();
                string Name = row["ProductName"].ToString();
                int ProductIf = Convert.ToInt32(row["ProductID"].ToString());
                string Review = row["Review"].ToString();
                string rating = row["Rating"].ToString();
                bool ISLike = Convert.ToBoolean(row["IsLike"].ToString());
                Console.WriteLine("ID :" + Id + ", ProductName : " + Name + ", Review : " + Review + ", Rating : " + rating + ", IsLike : " + ISLike);

            }
        }
        //Uc 9
        public void Retrieve_ISLike(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                bool IsLike = Convert.ToBoolean(row["IsLike"].ToString());
                string Name = row["ProductName"].ToString();
                if (IsLike == true)
                {
                    Console.WriteLine("Prduct Name : " + Name + ", IsLike : " + IsLike);
                }
            }

        }
        //UC 10
        public void Retrieve_Avg_Prodructs(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                double avg1 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 1).Select(c => Convert.ToDouble(c["Rating"])).Average();
                double avg2 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 2).Select(c => Convert.ToDouble(c["Rating"])).Average();
                double avg3 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 3).Select(c => Convert.ToDouble(c["Rating"])).Average();
                double avg4 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 4).Select(c => Convert.ToDouble(c["Rating"])).Average();
                double avg5 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 5).Select(c => Convert.ToDouble(c["Rating"])).Average();
                double avg10 = dt.Select().Where(p => Convert.ToInt32(p["ProductId"]) == 10).Select(c => Convert.ToDouble(c["Rating"])).Average();
                Print(avg1, avg2, avg3, avg4, avg5, avg10);
                void Print(double avg1, double avg2, double avg3, double avg4, double avg5, double avg10)
                {
                    Console.WriteLine("Product Id : 1, Avg2 : " + avg1 + "\nProduct Id : 2, Avg : " + avg2 + "\nProduct Id : 3, Avg : " + avg3 + "\nProduct Id : 4, Avg : " + avg4 + "\nProduct Id : 1, Avg : " + avg5 + "\nProduct Id : 10, Avg : " + avg10);
                }
                break;
            }
        }
        //UC 11
        public void NiceReview(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)

            {
                string IsLike = row["REview"].ToString();
                string Name = row["ProductName"].ToString();
                if (IsLike == "nice")
                {
                    Console.WriteLine("Prduct Name : " + Name + ", Review : " + IsLike);
                }
            }
        }

        //UC 12
        public void RatingOrder(DataTable dt)
        {

            var Rows = from row in dt.AsEnumerable() orderby row["Rating"] descending select row;
            DataTable dt1 = Rows.AsDataView().ToTable();
            Console.WriteLine("User Id , Product Name, Product Id , Rating , Review");
            Print(dt1);
            void Print(DataTable dt1)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    if (Convert.ToInt32(row["ID"]) == 10)
                    {
                        Console.WriteLine("\n {0},{1},{2},{3},{4},{5}", row[0], row[1], row[2], row[3], row[4], row[5]);
                    }
                }
            }
        }
    }
}