using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class FixedDeposits: Assets
    {
        private int sumVal;
        public override int SumVal
        {
            get { return sumVal; }
            set { sumVal = value; }
        }
            
        private int period;
        public override int Period 
        { 
            get{ return period; }
            set{ period = value; }
        }

        private Decimal rate;
        public override Decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private DateTime invDate;
        public override DateTime InvDate
        {
            get { return invDate; }
            set { invDate = value; }
        }
        
        //Over-ridden method for FD's
        public override Decimal getAssetPrice()
        {
            Decimal assetPrice;

            TimeSpan ts = DateTime.Now.Subtract(invDate);
            double accruedDays = ts.TotalDays;
            
            assetPrice = (sumVal + sumVal * (rate / 100) * Convert.ToDecimal(accruedDays / 365));
            
            Console.WriteLine("Current FD Value for "+ AssestName+" is : " + Math.Round(assetPrice,2));
            Console.WriteLine();

            return assetPrice;
        }
    }
}
