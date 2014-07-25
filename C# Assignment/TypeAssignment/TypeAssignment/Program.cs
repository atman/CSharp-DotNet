using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace LearningCSharp.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Assignment: Implement the interface ITypeCheck in a class and showcase different use cases 
             * of passing by Value and passing by Ref.*/

            ITypeCheck obj1 = new Employee();
            ITypeCheck obj = new Employee();


            int y=1;

            Employee emp1 = new Employee();
            emp1.EmpId = 1;
            emp1.Department = "Justice";
            emp1.Name = "Captain America";
            emp1.YearsOfExperience = 85;


            Employee emp2 = new Employee();
            emp2.EmpId = 99;
            emp2.Department = "Applied Sciences";
            emp2.Name = "Lucius Fox";
            emp2.YearsOfExperience = 37;

            do
            {
                Console.WriteLine("1: Pass by Value 2: Pass by Reference");
                int val1, val2, val3;
                val1 = Convert.ToInt32(Console.ReadLine());

                //Use a Switch statement for user input
                switch (val1)
                {
                    case 1:
                        Console.WriteLine("1: Change number by value 2: Change employee details by value");
                        val2 = Convert.ToInt32(Console.ReadLine());
                        switch (val2)
                        {
                            case 1:
                                
                                int num;
                                Console.WriteLine("Enter a number");
                                num = Convert.ToInt32(Console.ReadLine());
                                obj1.ChangeNumber1(num);
                                Console.WriteLine("Number after change: " + num);
                                break;
                           
                            case 2:

                                //Changing values and printing them
                                Console.WriteLine("Employee values before change");
                                Console.WriteLine();
                                Console.WriteLine("Name : " + emp1.Name);
                                Console.WriteLine("ID   : " + emp1.EmpId);
                                Console.WriteLine("Dept : " + emp1.Department);
                                Console.WriteLine("Exp  : " + emp1.YearsOfExperience);
                                Console.WriteLine();

                                obj1.ChangeEmployee1(emp1);

                                Console.WriteLine("Employee values after change");
                                Console.WriteLine();
                                Console.WriteLine("Name : " + emp1.Name);
                                Console.WriteLine("ID   : " + emp1.EmpId);
                                Console.WriteLine("Dept : " + emp1.Department);
                                Console.WriteLine("Exp  : " + emp1.YearsOfExperience);
                                Console.WriteLine();
                                break;

                        }
                        break;


                    case 2:

                        Console.WriteLine("1:Change number by reference 2:Change employee details by reference");
                        val3 = Convert.ToInt32(Console.ReadLine());
                        switch (val3)
                        {
                            case 1:

                                int num1;
                                Console.WriteLine("Enter a number");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                obj1.ChangeNumber2(ref num1);
                                Console.WriteLine("Number after change" + num1);
                                break;

                            case 2:

                                Console.WriteLine("Before Function Call:");
                                Console.WriteLine();
                                Console.WriteLine("Name : "+emp2.Name);
                                Console.WriteLine("ID   : "+emp2.EmpId);
                                Console.WriteLine("Dept : "+emp2.Department);
                                Console.WriteLine("Exp  : "+emp2.YearsOfExperience);
                                Console.WriteLine();

                                obj.ChangeEmployee2(ref emp2);

                                Console.WriteLine("After Function execution:");
                                Console.WriteLine();
                                Console.WriteLine("Name : "+emp2.Name);
                                Console.WriteLine("ID   : "+emp2.EmpId);
                                Console.WriteLine("Dept : "+emp2.Department);
                                Console.WriteLine("Exp  : "+emp2.YearsOfExperience);
                                Console.WriteLine();
                                break;

                        }
                        break;
                }
                //check for break condition
                Console.WriteLine("Do you wish to continue 1:Yes 2:No");
                y = Convert.ToInt32(Console.ReadLine());

            } while (y == 1);

            Console.ReadLine();

        }
    }
}
