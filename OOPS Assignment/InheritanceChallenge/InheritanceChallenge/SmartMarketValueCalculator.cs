using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class SmartMarketValueCalculator
    {
        public Decimal getCurrentValue(Assets [] assetData)
        {
            Decimal currentValue=0;

            //Loop through all assets and add their current values
            foreach (Assets asset in assetData) 
            {
                Console.WriteLine("Asset Type : "+ asset.GetType().ToString().Substring(21));
                currentValue += asset.getAssetPrice();   
            }

            return currentValue;
        }
    }
}
