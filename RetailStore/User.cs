using System;
using System.Collections.Generic;
using System.Text;

namespace RetailStore
{
    public class User
    {
        private int id;
        public string Name;
        public string Surname;
        public string Email; 
        private string Password;
        public string Telephone;
        public string Address;
        public string DNI;
        private List<Order> Orders;
        private List<wishlist> wishlist;

        public User()
        {
            wishlist = new List<wishlist>();
        }
        
    }


}
