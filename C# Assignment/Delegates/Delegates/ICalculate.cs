using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Delegates
{
   

    public interface ICalculate
    {   
        decimal Calculate(OperationType type, int i, int j);

        decimal Calculate(Calculator calcDelegate, int i, int j);
    }
}
