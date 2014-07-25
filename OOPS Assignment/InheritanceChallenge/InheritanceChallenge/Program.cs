using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of Assets stores FD, Equity and other type of assets
            //Alternatively use Lists
            Assets[] ast = new Assets[4];

            //Static Declaration of data
            ast[0] = new FixedDeposits();
            ast[0].AssestName = "Batman Capital";
            ast[0].SumVal = 50000;
            ast[0].Period = 5;
            ast[0].Rate = 8.5M;
            ast[0].InvDate = DateTime.Now.AddDays(-100);

            ast[1] = new FixedDeposits();
            ast[1].AssestName = "Lord Vader Capital";
            ast[1].SumVal = 50000;
            ast[1].Period = 10;
            ast[1].Rate = 9.5M;
            ast[1].InvDate = DateTime.Now.AddDays(-200);

            ast[2] = new FixedDeposits();
            ast[2].AssestName = "Spidey Capital";
            ast[2].SumVal = 50000;
            ast[2].Period = 1;
            ast[2].Rate = 7.5M;
            ast[2].InvDate = DateTime.Now.AddDays(-100);

            ast[3] = new EquityShares();
            ast[3].AssestName = "Bobwoogleogle Capital";
            ast[3].Quantity = 200;
            ast[3].CostPrice = 1005.75M;

            SmartMarketValueCalculator smvt = new SmartMarketValueCalculator();

            decimal value = smvt.getCurrentValue(ast);
            Console.WriteLine();
            Console.WriteLine("Current Value of all Assets is : "+ Math.Round(value,2));
            Console.ReadKey();

        }
    }
}
