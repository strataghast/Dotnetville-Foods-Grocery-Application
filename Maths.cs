using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_3_2
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    
    internal interface Maths
    {
        decimal Addition(decimal x, decimal y);
        decimal SalesTax(decimal x, decimal y);
        decimal Coupon(decimal x, decimal y);
    }
    class Calculations : Maths
    {
        public decimal Addition(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Coupon(decimal x, decimal y)
        {
            decimal total = x - (x * y);
            return total;
        }

        public decimal SalesTax(decimal x, decimal y)
        {
            decimal total = (x * y) + x;
            return total;
        }
    }
}
