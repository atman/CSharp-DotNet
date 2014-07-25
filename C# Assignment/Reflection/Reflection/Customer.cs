using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Reflection
{
    public class CustomerBase
    {
        public int CustomerId { get; set; }
    }

    public class Customer:CustomerBase
    {
        public string CustomerName { get; set; }
        public int NoOfOrders { get; set; }
        public decimal TotalOrderedAmount { get; set; }
    }
}
