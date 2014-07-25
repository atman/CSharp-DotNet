using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Delegates
{
    public class CalculateEx : ICalculate
    {
        public decimal Calculate(OperationType type, int i, int j)
        {  
            switch (type)
            {
                case OperationType.Add:
                    {
                        return i + j;

                    }
                case OperationType.Sub:
                    {
                        return i - j;

                    }
                case OperationType.Mul:
                    {
                        return i * j;

                    }
                case OperationType.Div:
                    {
                        return i / j;

                    }
                default:
                    return 0;

            }

        }
        //Function used for the Delegate 
        public static decimal modulus(int i, int j)
        {
            return i % j;
        }
        //The Function which uses the delegate type as a parameter
        public decimal Calculate(Calculator calcDelegate, int i, int j)
        {
            return calcDelegate(i, j);
        }

    }
}
