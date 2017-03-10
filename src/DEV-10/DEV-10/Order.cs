using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class Order
    {
        private int orderID;
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private string shopperName;
        public string ShopperName
        {
            get { return shopperName; }
            set { shopperName = value; }
        }
        private string shopperMail;
        public string ShopperMail
        {
            get { return shopperMail; }
            set { shopperMail = value; }
        }
        private Dictionary<Product, int> contents;
        public Dictionary<Product, int> Contents
        {
            get { return contents; }
            set { contents = value; }
        }
        private bool orderCompleted;
        public bool OrderCompleted
        {
            get { return orderCompleted; }
            set { orderCompleted = value; }
        }
    }
}
