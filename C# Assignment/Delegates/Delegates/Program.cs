using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCSharp.Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("The operations Add,Sub,Mul and Div implemented using a single Function");
            Console.WriteLine("The Fifth Operation 'Modulus' has been implemented using Delegates");
           
            //Enter the Two Elements
            int i, j;
            Console.WriteLine("Enter The First Element");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Element");
            j = Convert.ToInt32(Console.ReadLine());

            //Creating an object of class CalculateEx
            CalculateEx temp = new CalculateEx();
            //Switch Case
            do
            {
                Console.WriteLine();

                Console.WriteLine("List of operations that are required to be performed");

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus [Implemented Using Delegates]");
                Console.WriteLine("7. Asynchronus Addition");
                Console.WriteLine("Enter Your Choice");
                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                { //Implementation of Challenge 1
                    case '1':
                        //Function For Addition on basis of the Operation type
                        decimal add = temp.Calculate(OperationType.Add, i, j);
                        Console.WriteLine("The Sum Is:" + add);
                        break;
                    case '2':
                        //Function For Subtraction
                        decimal sub = temp.Calculate(OperationType.Sub, i, j);
                        Console.WriteLine("The Difference is:" + sub);
                        break;
                    case '3':
                        //Function For Multiplication
                        decimal mul = temp.Calculate(OperationType.Mul, i, j);
                        Console.WriteLine("The Product is:" + mul);
                        break;
                    case '4':
                        //Function For Division is Executed
                        decimal div = temp.Calculate(OperationType.Div, i, j);
                        Console.WriteLine("The Division is:" + div);
                        break;
                    case '5':
                        //Modulus Function is implemented differently
                        Console.WriteLine("Enter The Way in which the Modulus is to be calculated");
                        Console.WriteLine("1. Lamda");
                        Console.WriteLine("2. Simple Function Pointer");
                        char ch1 = Convert.ToChar(Console.ReadLine());
                        switch (ch1)
                        {
                            case '1':
                                //Implementation Using Lamda
                                Console.WriteLine("The Function Definition is done using Lamda operator");

                                //Define Lamda statically
                                Calculator lamda = (p, q) => p % q;

                                //Calling the Delegate
                                decimal lamdaoutput = temp.Calculate(lamda, i, j);
                                Console.WriteLine("Output using Lamda:" + lamdaoutput);
                                break;
                            case '2':
                                //Implementation using simple function pointer
                                Console.WriteLine("Simple Function Pointer");

                                //Reference to Delegate Function Modulus 
                                Calculator functionpointer = CalculateEx.modulus;

                                //Calling the Delegate
                                decimal fpoutput = temp.Calculate(functionpointer, i, j);
                                Console.WriteLine(fpoutput);
                                break;

                        }
                        break;
                    case '7':
                        //Async Call
                        Console.WriteLine("Asynchronus Call");

                        Calculator asynccall = DelayedAdd;

                        IAsyncResult asyncresult = asynccall.BeginInvoke(i, j, null, null);

                        Console.WriteLine("Main Thread Executing...");
                        Console.WriteLine("No Waiting for func. to finish execution");

                        decimal result = asynccall.EndInvoke(asyncresult);
                        Console.WriteLine(result);
                        break;
                }

                Console.WriteLine("Do You Wish To Continue");
                Console.WriteLine("Reply Y for 'Yes' or any other Character for 'No'");
                character = Convert.ToChar(Console.ReadLine());
            }
            while (character == 'Y' || character == 'y');
            Console.ReadKey();
           
            }

            private static decimal DelayedAdd(int i, int j)
            {
            
                Console.WriteLine("Function Executes");
                Thread.Sleep(5000);
                return i + j;

            }
    }
}
