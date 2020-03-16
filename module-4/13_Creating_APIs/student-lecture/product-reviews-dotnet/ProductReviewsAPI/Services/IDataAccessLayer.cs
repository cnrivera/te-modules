using System;
using System.Collections.Generic;

namespace ProductReviewsAPI.Services {
    
    public interface IDataAccessLayer<ProductReview>
    { 
        List<ProductReview> GetAll();
        ProductReview Get(int id);
        void Add(ProductReview productReview);
        void Update(ProductReview productReview);
        void Delete(int id);
    }

}