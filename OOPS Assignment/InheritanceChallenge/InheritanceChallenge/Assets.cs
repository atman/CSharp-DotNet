using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Assets
    {
        private int assetId;
        public int AssetId
        {
            get { return assetId; }
            set { assetId = value; }
        }

        private String assetName;
        public String AssestName
        {
            get { return assetName; }
            set { assetName = value; }
        }

        public virtual int SumVal{ get;set;}
        public virtual int Period { get; set; }
        public virtual Decimal Rate { get; set; }
        public virtual DateTime InvDate { get; set; }

        public virtual int Quantity { get; set; }
        public virtual Decimal CostPrice { get; set; }


        public virtual Decimal getAssetPrice()
        {
            return 0;
        }
    }
}
