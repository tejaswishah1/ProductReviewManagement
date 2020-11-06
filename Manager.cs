using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    class Manager
    {
        public readonly DataTable dataTable = new DataTable();

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
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message); 
            }
        }
    }
}
