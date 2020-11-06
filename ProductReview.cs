namespace ProductReviewManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Declaring the fields:
    /// </summary>
    class ProductReview
    {
        /// <summary>
        /// Product ID
        /// </summary>
        public int ProducID { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Rating of the product
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// Review (Nice,Good,Very Good etc)
        /// </summary>
        public string Review { get; set; }

        /// <summary>
        /// Boolean value.
        /// </summary>
        public bool isLike { get; set; }
    }
}
