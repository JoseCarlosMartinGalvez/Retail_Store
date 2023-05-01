using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Product
    {
        public int ID;
        public bool Visible;
        public string name;
        public string brand;
        public string description;
        public int basePrice;
        public int discount;
        public bool stock;
        public List<string> images;
        public List<Label> labels;
        public Category category;
        public Subcategory subcategory;
        public List<Review> Review;

        public void AddLabel (string label)
        {
        
        }
    }

}
