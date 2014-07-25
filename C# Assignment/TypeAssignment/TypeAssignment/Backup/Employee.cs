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


        public Employee()
        {
       
        }


    

        void ITypeCheck.ChangeEmployee2(ref Employee emp)
        {
           
            Employee temp=new Employee();
            temp.Department="Mechanical";
            temp.Name="Kothavle";
            temp.EmpId = 007;
            temp.YearsOfExperience = 0;

            Console.WriteLine("\nInside Function Call:");

            emp.Department = temp.Department;
            emp.Name = temp.Name;
            emp.EmpId = temp.EmpId;
            emp.YearsOfExperience =temp.YearsOfExperience;


            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.Department);
            Console.WriteLine(emp.YearsOfExperience);

            
        
        }
      
        
        void ITypeCheck.ChangeEmployee1(Employee emp)
        {

 
           /* Employee temp=new Employee();
            temp.Department="Mechanical";
            temp.Name="Kothavle";
            temp.EmpId = 007;
            temp.YearsOfExperience = 0;*/

            Console.WriteLine("\nInside Function Call: ");

            emp.Department = "it";
            emp.Name = "vignesh";
            emp.EmpId = 3;
            emp.YearsOfExperience =8;


            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.Department);
            Console.WriteLine(emp.YearsOfExperience);
            return;

        }

       void ITypeCheck.ChangeNumber1(int number)
        {

            number += 5;
            Console.WriteLine("\nNumber inside function" + number);
        }

         void ITypeCheck.ChangeNumber2(ref int number)
         {
             number += 8;
             Console.WriteLine("\nNumber inside function" + number);

         }
    }
}
