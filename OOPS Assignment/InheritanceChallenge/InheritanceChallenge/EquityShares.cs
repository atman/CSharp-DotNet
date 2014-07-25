using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class EquityShares: Assets
    {
        private int quantity;
        public override int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private Decimal costPrice;
        public override Decimal CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }
        //Over-ridden method for Equities
        public override Decimal getAssetPrice()
        {
            Decimal currentEquityShareValue = 0;
            Decimal marketPrice = costPrice * 1.09M;

            currentEquityShareValue = quantity * marketPrice;
            Console.WriteLine("Current Equity Value for "+ AssestName+" is : " + Math.Round(currentEquityShareValue,2));

            return currentEquityShareValue;
        }
    }
}
