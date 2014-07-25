using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Reflection
{
    public interface IBase
    {
        void DoWork();
    }


    public class Child1:IBase
    {
        void IBase.DoWork()
        {
            Console.WriteLine("Child 1 implements IBase");
            throw new NotImplementedException();
        }
    }

    public class Child2
    {
        public void DoWork()
        {
            Console.WriteLine("Child 2 does NOT implement IBase");
            throw new NotImplementedException();
        }
    }

    public class Child3
    {
         
    }
}
