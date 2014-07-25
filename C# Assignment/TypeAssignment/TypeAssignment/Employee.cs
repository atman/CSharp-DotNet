using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace LearningCSharp.Types
{
    public class Employee:ITypeCheck
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal YearsOfExperience { get; set; }

        //Overriding interface functions
        void ITypeCheck.ChangeEmployee1(Employee emp)
        {
            //Create a new obj to simulate pass by value
            emp = new Employee();
            //Alternatively we can use a copy constructor and pass the new copy of the type
            emp.EmpId = 3;
            emp.Name = "Atman";
            emp.Department = "Comps";
            emp.YearsOfExperience = 0;

            return;

        }

        void ITypeCheck.ChangeEmployee2(ref Employee emp)
        {
            //Create a new temp obj to store ref. into
            Employee temp = new Employee();
            temp.Name = "Batman";
            temp.EmpId = 7;
            temp.Department = "Krav Maga";
            temp.YearsOfExperience = 12;

            //Assign new obj ref. to passed ref.
            emp = temp;

        }

       void ITypeCheck.ChangeNumber1(int number)
        {

            number += 7 ;
            Console.WriteLine("After Change by Value (num+7) : " + number);
        }

         void ITypeCheck.ChangeNumber2(ref int number)
         {
             number += 13;
             Console.WriteLine("After Change By Ref (num+13): " + number);

         }
    }
}
