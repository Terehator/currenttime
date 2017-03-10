
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class Product
    {
        private int productID;
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
    }
}
