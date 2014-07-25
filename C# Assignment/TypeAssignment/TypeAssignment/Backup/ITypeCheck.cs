using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace LearningCSharp.Types
{
    public interface ITypeCheck
    {
        void ChangeEmployee1(Employee employee);
        void ChangeEmployee2(ref Employee employee);

        void ChangeNumber1(int number);
        void ChangeNumber2(ref int number);

    }
}
