using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class Category
    {
        public int Id;
        public string Name; 
        public string Description;
        public List<Subcategory> Subcategories;

    
    }

    public class Subcategory : Category 
    { 

    }

    public class SubSubcategory : Subcategory
    {

    }

}
