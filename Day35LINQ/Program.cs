using System;
using System.Collections.Generic;
using System.Linq;

namespace Day35LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //UC 1
            Console.WriteLine("Product Review Management with Linq");
            //List<ProductReview> listofpr = new List<ProductReview>()
            //{
            //    new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
            //    new ProductReview(){ProductID=1,UserID=2,Rating=4,Review="Okay",isLike=false},
            //    new ProductReview(){ProductID=2,UserID=3,Rating=6,Review="Good",isLike=true},
            //    new ProductReview(){ProductID=2,UserID=4,Rating=3,Review="Bad",isLike=false},
            //    new ProductReview(){ProductID=3,UserID=5,Rating=8,Review="Good",isLike=true},
            //    new ProductReview(){ProductID=4,UserID=6,Rating=2,Review="Very Bad",isLike=false},
            //    new ProductReview(){ProductID=5,UserID=7,Rating=10,Review="Perfect",isLike=true},
            //    new ProductReview(){ProductID=5,UserID=8,Rating=7,Review="Nice",isLike=false},
            //    new ProductReview(){ProductID=3,UserID=9,Rating=0,Review="Very Bad",isLike=false},
            //    new ProductReview(){ProductID=4,UserID=10,Rating=4,Review="Okay",isLike=false},
            //    new ProductReview(){ProductID=5,UserID=11,Rating=6.5,Review="Good",isLike=true},
            //    new ProductReview(){ProductID=2,UserID=12,Rating=3,Review="Bad",isLike=false},
            //    new ProductReview(){ProductID=3,UserID=13,Rating=8,Review="Very Good",isLike=true},
            //    new ProductReview(){ProductID=9,UserID=14,Rating=2,Review="Bad",isLike=false},
            //    new ProductReview(){ProductID=9,UserID=15,Rating=9,Review="Perfect",isLike=true},
            //    new ProductReview(){ProductID=9,UserID=16,Rating=7,Review="Nice",isLike=false}
            //};
            //foreach (var list in listofpr)
            //{
            //    Console.WriteLine("ProductID : " + list.ProductID + ", User ID : " + list.UserID + ", Rating :" + list.Rating + ", Review : " + list.Review + ", isLike : " + list.isLike);
            //}

            //UC 2
            //Management management = new Management();
            //management.TopRecords(listofpr);

            //UC 3
            //management.SelectRecords(listofpr);

            //UC 4 
            //management.RetrieveCount(listofpr);

            //UC 5
            //management.RetrieveProductId_Rating(listofpr);

            //UC 6
            //management.SkipTop_5_Records(listofpr);

            //UC 7
            //management.RetrieveProductId_RatingUsingSelect(listofpr);

            //UC 8
            //Console.WriteLine("LINQ to Data Table!");
            LinqToDataTable ldt = new LinqToDataTable();
            //ldt.AddToTable();

            //UC 9
            //ldt.AddToTable();
            
            //UC 10
            ldt.AddToTable();

        }
    }
}
