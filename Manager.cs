using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProductReviewManagement
{
    class Manager
    {
        //    public readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// UC2: Retrieve top 3 Data
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            try
            {
                ////LINQ Query:
                var recordedData = (from productReviews in listProductReview
                                    orderby productReviews.Rating descending
                                    select productReviews).Take(3);
                ////Printing Top 3 products:
                foreach (var list in recordedData)
                {
                    Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                        + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                }
            }
            ////Catch exception if any
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// UC3: Product ID=1/4/9, and rating greater than 3
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            try
            {
                var recordedData = from productReviews in listProductReview
                                   where (productReviews.ProducID == 1 || productReviews.ProducID == 4 ||
                                   productReviews.ProducID == 9)
                                   && productReviews.Rating > 3
                                   select productReviews;
                Console.WriteLine("Rating greater than 3 with product ID of 1 or 4 or 9 :- \n");
                ////Print required fields:
                foreach (var list in recordedData)
                {
                    Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                        + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                }
            }
            ////Catch exception if any
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// UC4: Retrieve Count
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveCount(List<ProductReview> listProductReview)
        {
            try
            {
                var recordedData = from productReviews in listProductReview
                                   group productReviews by productReviews.ProducID into prodGroup
                                   select new
                                   {
                                       ProducID = prodGroup.Key,
                                       Count = prodGroup.Count(),

                                   };
                ////Retrieve data
                foreach (var list in recordedData)
                {
                    Console.WriteLine("ProductID:- " + list.ProducID + " " + "Count: " + list.Count);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        /// <summary>
        /// UC5: Retrieve Product ID and Review Only
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveProductIDandReview(List<ProductReview> listProductReview)
        {
            try
            {
                var recordedData = from productReviews in listProductReview
                                   select new
                                   {
                                       productReviews.ProducID,
                                       productReviews.Review
                                   };
                ////Retrieve Data
                foreach (var list in recordedData)
                {
                    Console.WriteLine("Product ID:- " + list.ProducID +" "+ "Review: " + list.Review);
                }
            }
            ////Catch exception if any:
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        /// <summary>
        /// UC6 Skip first 5 records and display the rest
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SkipFirstFiveRecords(List<ProductReview> listProductReview)
        {
            try
            {
                ////Skip top 5 data
                var recordedData = (from productReviews in listProductReview
                                    select productReviews).Skip(5);
                Console.WriteLine("\n");

                ////Print remaining data
                foreach (var list in recordedData)
                {
                    Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                           + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
                }                                   
            }
            ////Catch exception is any
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Average Rating of each Product ID
        /// </summary>
        /// <param name="listProductReview"></param>
        public void AverageRatingOfEachProductId(List<ProductReview> listProductReview)
        {
            ////LINQ Query
            var data = from productReviews in listProductReview
                       group productReviews by productReviews.ProducID into avg
                       select new
                       {
                           ProductID = avg.Key,
                           AverageRating = avg.Average(x => x.Rating) ////Lambda function
                       };
            Console.WriteLine("\n");
            Console.WriteLine("\nProductID AverageRating");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + "   " + list.AverageRating);
            }
        }

        /// <summary>
        /// Retrive data with review = Nice
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RecordWithReviewNice(List<ProductReview> listProductReview)
        {
            var data = from productReviews in listProductReview
                       where (productReviews.Review == "Nice")
                       select productReviews;
            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProducID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }

    }
}