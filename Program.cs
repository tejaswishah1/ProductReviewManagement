using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {

        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            ////Intro:
            Console.WriteLine("Welcome to Product Review Management \n");

            ////List to add 25 Products:
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProducID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=2,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=4,UserID=3,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="Nice",isLike=true},
                new ProductReview(){ProducID=6,UserID=4,Rating=1,Review="Bad",isLike=true},
                new ProductReview(){ProducID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProducID=8,UserID=5,Rating=8,Review="Nice",isLike=true},
                new ProductReview(){ProducID=2,UserID=2,Rating=11,Review="Nice",isLike=true},////Rating 11
                new ProductReview(){ProducID=10,UserID=4,Rating=8,Review="Nice",isLike=true},
                new ProductReview(){ProducID=11,UserID=5,Rating=3,Review="Nice",isLike=true},
                new ProductReview(){ProducID=12,UserID=2,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProducID=12,UserID=4,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=13,UserID=6,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=14,UserID=3,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProducID=14,UserID=4,Rating=2,Review="Nice",isLike=true},
                new ProductReview(){ProducID=15,UserID=1,Rating=1,Review="Bas",isLike=true},
                new ProductReview(){ProducID=15,UserID=5,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProducID=18,UserID=1,Rating=9,Review="Nice",isLike=true},
                new ProductReview(){ProducID=19,UserID=2,Rating=12,Review="Nice",isLike=true},////Rating 12
                new ProductReview(){ProducID=22,UserID=3,Rating=8,Review="Nice",isLike=true},
                new ProductReview(){ProducID=21,UserID=2,Rating=3,Review="Nice",isLike=true},
                new ProductReview(){ProducID=22,UserID=5,Rating=10,Review="Nice",isLike=true},////Rating 10
                new ProductReview(){ProducID=22,UserID=4,Rating=8,Review="Good",isLike=true},
                new ProductReview(){ProducID=25,UserID=3,Rating=3,Review="Bad",isLike=true}
            };

            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
            //             + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            //}

            ////Calling Manager class to retreive top 3 Data:
            Manager manager = new Manager();
            //manager.TopRecords(productReviewList);

            ////Product ID: 1/4/9 And rating >3:
            //manager.SelectedRecords(productReviewList);

            ////Retrieve Count of ProductID:
            //manager.RetrieveCount(productReviewList);

            ////Retrieve Product ID and review only
            //manager.RetrieveProductIDandReview(productReviewList);

            ////Skip first 5 records:
            //manager.SkipFirstFiveRecords(productReviewList);

            ////UC8: DataTable
            DataTables dataTables = new DataTables();
            //dataTables.AddDataToTable();

            ////UC9: For IsLike= true:
            //dataTables.GetDataForIsLikeTrue();

            ////UC10 Average rating
            manager.AverageRatingOfEachProductId(productReviewList);

        }
    }
}
