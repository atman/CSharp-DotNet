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
            Employee f = new Employee();
            f.EmpId = 2;
            f.Department = "it";
            f.Name = "Vijay";
            f.YearsOfExperience = 3;


            Employee e = new Employee();
            e.EmpId = 1;
            e.Department = "cmpn";
            e.Name = "Nupur";
            e.YearsOfExperience = 7;

            do
            {
                Console.WriteLine("1:Pass by Value 2:Pass by Reference");
                int val1, val2, val3;
                val1 = Convert.ToInt32(Console.ReadLine());

                switch (val1)
                {
                    case 1:
                        Console.WriteLine("1:Change number by value 2:Change employee details by value");
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

                                Console.WriteLine("\nEmployee values before change");
                                Console.WriteLine(f.Name);
                                Console.WriteLine(f.EmpId);
                                Console.WriteLine(f.Department);
                                Console.WriteLine(f.YearsOfExperience);


                                obj1.ChangeEmployee1(f);

                                Console.WriteLine("\nEmployee values after change");
                                Console.WriteLine(f.Name);
                                Console.WriteLine(f.EmpId);
                                Console.WriteLine(f.Department);
                                Console.WriteLine(f.YearsOfExperience);
                                break;

                        }
                        break;


                    case 2:
                        Console.WriteLine("\n1:Change number by reference 2:Change employee details by reference");
                        val3 = Convert.ToInt32(Console.ReadLine());
                        switch (val3)
                        {
                            case 1:
                                int num1;
                                Console.WriteLine("Enter a number");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                obj1.ChangeNumber2(ref num1);
                                Console.WriteLine("\nNumber after change" + num1);
                                break;
                            case 2:
                                Console.WriteLine("\nBefore Function Call:");
                                Console.WriteLine(e.Name);
                                Console.WriteLine(e.EmpId);
                                Console.WriteLine(e.Department);
                                Console.WriteLine(e.YearsOfExperience);

                                obj.ChangeEmployee2(ref e);

                                Console.WriteLine("\nafter Function execution:");
                                Console.WriteLine(e.Name);
                                Console.WriteLine(e.EmpId);
                                Console.WriteLine(e.Department);
                                Console.WriteLine(e.YearsOfExperience);
                                break;

                        }
                        break;


                }

                Console.WriteLine("Do you wish to continue 1:Yes 2:No");
                y = Convert.ToInt32(Console.ReadLine());

            } while (y == 1);

        
           
            Console.ReadLine();

        }
    }
}
