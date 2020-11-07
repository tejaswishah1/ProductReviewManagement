using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviewManagement
{

    /// <summary>
    /// Class Data table
    /// </summary>
   public class DataTables
    {
        public static DataTable table = new DataTable();
        /// <summary>
        /// Adding Data To Table
        /// </summary>
        public void AddDataToTable()
        {
            ////Table created:
            
            ////Columns added:
            table.Columns.Add("ProductID"); table.Columns.Add("UserID");
            table.Columns.Add("Rating"); table.Columns.Add("Review"); table.Columns.Add("IsLike");
            ////Rows added:
            table.Rows.Add("1", "1", "5", "Good", true);
            table.Rows.Add(2, 2, 7, "Good", true);
            table.Rows.Add(3, 3, 5, "Good", true);
            table.Rows.Add(20, 4, 10, "Good", true);
            table.Rows.Add(23, 5, 6, "Nice", false);
            table.Rows.Add(6, 6, 3, "Nice", false);
            table.Rows.Add(20, 7, 2, "Bad", false);
            table.Rows.Add(8, 8, 1, "Nice", false);
            table.Rows.Add(20, 20, 9, "Good", true);
            table.Rows.Add(21, 21, 3, "Nice", false);
            table.Rows.Add(11, 11, 3, "Nice", false);
            table.Rows.Add(14, 14, 10, "Good", true);
            table.Rows.Add(23, 23, 4, "Good", true);
            DisplayValuesOfTable(table);
        }    
        
        public void DisplayValuesOfTable(DataTable table)
        {
            try
            {
                ////Selecting all data
                var productNames = from product in table.AsEnumerable() select product;

                ////printing all data
                foreach (var data in productNames)
                {
                    Console.WriteLine("ProductID: " + data.Field<string>("ProductID") +
                        ", UserID: " + data.Field<string>("UserID") + ", Ratings: " +
                        data.Field<string>("Rating") + " , Review: " + data.Field<string>("Review")
                        + " , IsLike: " + data.Field<string>("IsLike"));
                }
            }
            ////Catch exception if any
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Get data for products where Is like = true
        /// </summary>
        public void GetDataForIsLikeTrue()
        {
            try
            {
                var productNames = from product in table.AsEnumerable()
                                   where (product.Field<bool>("isLike")==true)
                                   select product;

                foreach (var data in productNames)
                {
                    Console.WriteLine("ProductID: " + data.Field<string>("ProductID") +
                        ", UserID: " + data.Field<string>("UserID") + ", Ratings: " +
                        data.Field<string>("Rating") + " , Review: " + data.Field<string>("Review")
                        + " , IsLike: " + data.Field<string>("IsLike"));
                }
            }
            ////Catch exception if any
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


        }

    }
}
