using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Delegates
{
    public enum OperationType
    {
        Add = 1,
        Sub = 2,
        Mul = 3,
        Div = 4
    }

    public delegate decimal Calculator(int i, int j);
}
