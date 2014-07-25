using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace LearningCSharp.Collections
{
    public class Program
    {
        private OrderedDictionary employees = new OrderedDictionary();
        static void Main(string[] args)
        {
            /*Assignment 1:
             * Create 10,000 instances of Employees and add them to the chosen collection in each case.
             * The collection needs to be picked and the operation should be repeated for following cases:
             * 1. Optimized for Search by EmpId
             * 2. Optimized for insert & delete
             * 3. Optimized for insert at a specific index
             * 4. Optimized to provide sorted results.
             * 5. Optimized for low memory consumption.
             * 
             * For each of the above cases, test & profile the results and then conclude.*/

            /*Assignment 2: Read instructions in class EmployeeList.cs. */

            //Else make employees static
            Program p = new Program();

            //Used for insertion of random values
            Random ran = new Random();

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting adding....");
            stopwatch.Start();

            //Inserting 10000 dummy data
            for (int i = 0; i < 10000; i++)
            {
                Employee obj = new Employee();
                obj.EmpId = (10000-i);
                obj.EmpName = "Emp" + (i + 1);
                obj.Department = "Dept" + ran.Next(10);
                obj.YearsOfExperience = ran.Next(40);

                p.employees.Add(obj.EmpId, obj);

                //Displying take a lot of time
                //p.showEmployees();  
            }

            stopwatch.Stop();
            Console.WriteLine("Time taken to add : " + stopwatch.Elapsed);
            
            //Call the GUI Screen
            p.guimenu();
        }

        void guimenu()
        {
            int choice;
            do
            {
                Console.WriteLine("Please choose an option\n1.Add Employee\n2.Insert at specified index\n3.Delete                   Employee\n4.Show Employees\n5.Sort Employees\n6.Search Employee\n7.Exit");
                choice = int.Parse(Console.ReadLine());

                //Switch case
                switch (choice)
                {
                    case 1: insertEmployee(); break;
                    case 2: insertAtIndex(); break;
                    case 3: deleteEmployee(); break;
                    case 4: showEmployees(); break;
                    case 5: sortEmployees(); break;
                    case 6: searchEmployee(); break;

                    case 7: break;
                    default: break;
                }
                Console.WriteLine("Would you like to continue.Press \n 1.Yes \n 2.No");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice != 2);

        }

        //Insert employee at the end
        void insertEmployee()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting insertion....");
            stopwatch.Start();

            Employee e = new Employee();
            Console.WriteLine("Enter a unique EmpId");
            e.EmpId = int.Parse(Console.ReadLine());
            
            //Check if dictionary contains same ID
            if (employees.Contains(e.EmpId))
            {
                Console.WriteLine("This ID already exists");
                return;
            }
            Console.WriteLine("Enter the Employee Name : ");
            e.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Department : ");
            e.Department = Console.ReadLine();
            Console.WriteLine("Enter Experience : ");
            e.YearsOfExperience = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Record inserted");
            employees.Add(e.EmpId, e);

            stopwatch.Stop();
            Console.WriteLine("Time taken to insert : " + stopwatch.Elapsed);
        }

        //Display employees
        void showEmployees()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting display....");
            stopwatch.Start();

            IDictionaryEnumerator myEnumerator =employees.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                display((Employee)myEnumerator.Value);
            }

            stopwatch.Stop();
            Console.WriteLine("Time taken to show : " + stopwatch.Elapsed);

        }

        //Display info of employees (called from showEmployees)
        void display(Employee e)
        {
            Console.WriteLine("Employee Id : "+e.EmpId);
            Console.WriteLine("Employee Name : " + e.EmpName);
            Console.WriteLine("Department : " + e.Department);
            Console.WriteLine("Years Of Experience : " + e.YearsOfExperience);
            Console.WriteLine("-----------------------------------------------------");
            
        }

        //Search based on empId
        void searchEmployee()
        {
            Console.Write("Enter the employee id to search for: ");
            int id = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting search....");
            stopwatch.Start();

            //OrderedDictionary func is used
            if (employees.Contains(id))
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Employee Found");
               
                //Loop to find and display that employee if found
                IDictionaryEnumerator myEnumerator = employees.GetEnumerator();
                while (myEnumerator.MoveNext())
                {
                    if (id == (int)myEnumerator.Key)
                    {
                        display((Employee)myEnumerator.Value);
                        break;
                    }
                }
            }
            else
                Console.WriteLine("No employee found with this id");

            stopwatch.Stop();
            Console.WriteLine("Time taken to search : " + stopwatch.Elapsed);

        }

        //Delete based on key
        void deleteEmployee()
        {        
            Console.WriteLine("Enter the employee id to delete");
            int id = int.Parse(Console.ReadLine());
            if (employees.Contains(id))
            {
                employees.Remove(id);
                Console.WriteLine("Employee data deleted from the database");
            }
            else
                Console.WriteLine("No employee found with this id");
        }

        //Insert at particular index of dictionary
        void insertAtIndex()
        {
            Console.WriteLine("Enter the index where you want to insert this new employee");
            int index = int.Parse(Console.ReadLine());
            
            Employee e = new Employee();
            Console.WriteLine("Enter the empid");
            e.EmpId = int.Parse(Console.ReadLine());

            if (employees.Contains(e.EmpId))
            {
                Console.WriteLine("this id already exist");
                return;
            }

            Console.WriteLine("Enter the Empname : ");
            e.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the department : ");
            e.Department = Console.ReadLine();
            Console.WriteLine("Enter the Experience : ");
            e.YearsOfExperience = Convert.ToDecimal(Console.ReadLine());
           
            employees.Insert(--index, e.EmpId, e);
            Console.WriteLine("Record Inserted");
        }
        void sortEmployees()
        {
            //To track performance
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting sorting....");
            stopwatch.Start();

            //Sorting and storing in a var
            var sortedDictionary = employees.Cast<DictionaryEntry>()
                .OrderBy(r => r.Key)
                .ToDictionary(c => c.Key, d =>d.Value);

            //For displaying after sorting
            IDictionaryEnumerator myEnumerator = sortedDictionary.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                display((Employee)myEnumerator.Value);
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken to sort : "+stopwatch.Elapsed);
        }

    }
}
