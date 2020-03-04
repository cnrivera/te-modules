using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviewList = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, rating, review_title, review_text, review_date FROM reviews ORDER BY review_date DESC", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviewList.Add(MapRowToForumPost(reader));
                }

            }
            return reviewList;
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public void SaveReview(Review newReview)
        {
            try
            {
                // Create a new connection object
                using (var conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    var sql = $"INSERT into reviews values(@username,@rating,@review_title,@review_text, @review_date)";
                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);
                    cmd.Parameters.AddWithValue("@review_date", DateTime.Now);

                    // Execute the command
                    var reader = cmd.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        private Review MapRowToForumPost(SqlDataReader reader)
        {
            return new Review()
            {
                Username = Convert.ToString(reader["username"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                ReviewText = Convert.ToString(reader["review_text"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"])
            };
        }
    }

       

    
}

