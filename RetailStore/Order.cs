using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Order
    {
        public int id;
        public int orderNumber;
        public DateTime OrderDate;
        public List<Product> Products;
        public List<int> Quantities;
        public decimal FinalPrice;
        public User User;

        public void order(Order order) 
        { 

        }

        public void AddReview(Product product,Review review)
        {

        }
          
        
       
    }

}
