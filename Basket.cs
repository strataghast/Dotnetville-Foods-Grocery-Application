using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_3_2
{
    internal class Basket
    {
        private int itemnumber;
        private string productname;
        private double productprice;
        private int productquantity;
        private double baskettotal;
        
        public int itemNumber { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productQuanitity { get; set; }
        internal class Data
        {
            public static List<Basket> basketData = new List<Basket>();
        }
    }
}
