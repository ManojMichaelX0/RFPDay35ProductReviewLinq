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


            dt.Rows.Add(1, "Chai",1, "Good", 8, true);
            dt.Rows.Add(2, "Coffee",1, "nice", 6, true);
            dt.Rows.Add(3, "Green Tea",1, "Bad", 4, false);
            dt.Rows.Add(4, "Thumbs UP",2, "Great", 9, true);
            dt.Rows.Add(5, "Montian Dew",2, "Good", 9, true);
            dt.Rows.Add(6, "Sting",2, "Bad", 4, false);
            dt.Rows.Add(7, "Maaza",3, "Very Good", 10, true);
            dt.Rows.Add(8, "Frooti",3, "Good", 7, true);
            dt.Rows.Add(9, "Sprit",2, "Bad", 3, false);
            dt.Rows.Add(10, "coco cola",2, "Great", 10, true);
            dt.Rows.Add(11, "Limca",3, "Good", 9, true);
            dt.Rows.Add(12, "Bisleri",4, "Good", 6, true);
            dt.Rows.Add(13, "Slice",3, "Good", 8, true);
            dt.Rows.Add(14, "Kinley",4, "Good", 6, true);
            dt.Rows.Add(15, "Kafe Strong",5, "nice", 7, true);
            dt.Rows.Add(16, "Knock Out",5, "Great", 9, true);
            dt.Rows.Add(17, "Kafe Lite",5, "Worst", 2, false);
            dt.Rows.Add(18, "Rum",6, "Great", 10, true);
            dt.Rows.Add(19, "Whiskey",6, "Very Good", 10, true);
            dt.Rows.Add(20, "Vodka",6, "nice", 7, true);
            dt.Rows.Add(21, "Brandi",6, "Bad", 3, false);
            dt.Rows.Add(22, "Champaine",5, "Great", 10, true);
            dt.Rows.Add(23, "RedBull",2, "nice", 9, true);
            dt.Rows.Add(24, "Gluco plus",2, "Good", 8, true);
            dt.Rows.Add(25, "Red Wine",6, "Okay", 6, true);

            //    DisplayProducts(dt);
            //Uc 9
            //Retrieve_ISLike(dt);

            //Uc 10
            //Retrieve_Avg_Prodructs(dt);

            //UC 11
            NiceReview(dt);
        }
        public void DisplayProducts(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
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
        //UC 10
        public void Retrieve_Avg_Prodructs(DataTable dt)
        {
            
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

        
    }
}
