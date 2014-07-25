using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace LearningCSharp.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Assignment 1: 
             * a. Create an instance of class Customer using Reflection.
             * b. Set values to all its properties including base class, using reflection.
             * */

            //Requires the full name including namespace else throws exception
            String nameDerived = "LearningCSharp.Reflection.Customer";
           
            //Get the property names and set values
            String property1 = "CustomerName";
            String value1 = "Atman";

            String property2 = "NoOfOrders";
            int value2 = 10;

            String property3 = "TotalOrderedAmount";
            decimal value3 = 3000;

            //Base class property of class Customer
            String property4 = "CustomerId";
            int value4 = 42;

            //Get type of declaration
            Type type = Type.GetType(nameDerived, true);

            //Create obj of the received type
            Object obj = Activator.CreateInstance(type);

            //Get each property of the created object and Set its values
            PropertyInfo propInfo = type.GetProperty(property1);
            propInfo.SetValue(obj, value1, null);

            propInfo = type.GetProperty(property2);
            propInfo.SetValue(obj, value2, null);

            propInfo = type.GetProperty(property3);
            propInfo.SetValue(obj, value3, null);

            propInfo = type.GetProperty(property4);
            propInfo.SetValue(obj, value4, null);

            //Print its Values
            Console.WriteLine("Customer Name: " + ((Customer)obj).CustomerName);
            Console.WriteLine("No of Orders: " + ((Customer)obj).NoOfOrders);
            Console.WriteLine("Total Ordered Amount: " + ((Customer)obj).TotalOrderedAmount);
            Console.WriteLine("Customer ID(Base class property): "+ ((Customer)obj).CustomerId);

            Console.WriteLine();

            /*Assignment 2: In InterfaceSearch.cs, using Reflection find all Child classes that are of the type IBase. */

            
            Type baseType = typeof(IBase);
            //Loop through all assemblies
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                //Loop through all the types in the assemblies
                foreach (Type t in asm.GetTypes())
                {
                    //Check if req. type is found
                    if (baseType.IsAssignableFrom(t))
                    {
                        //Additional filter to not show the base interface/class
                        if (t.ToString().Contains("IBase"))
                            Console.WriteLine("The interface is : " + t.ToString().Substring(26));
                        else
                            Console.WriteLine("Interface being implemented by : " + t.ToString().Substring(26));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
