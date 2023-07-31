using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Assignment_19_Part1
{
    delegate T Operation<T>(T a, T b);
    internal class Part2
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Diff(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Mul(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1/n2;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is Generic Delegate\n");
                Operation<int> add = Add;
                Operation<int> diff = Diff;
                Operation<int> mul = Mul;
                Operation<int> div = Div;
                Console.WriteLine("Enter Number One");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number Two");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nSelect the Operation to Perform\n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\n");
                Console.WriteLine("Which function You Want to perform?");
            again:
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            int result = Add(n1, n2);
                            Console.WriteLine($"\nThe Addition of {n1} and {n2} is {result}");
                            break;
                        }
                    case 2:
                        {
                            int result = Diff(n1, n2);
                            Console.WriteLine($"\nThe Substraction of {n1} and {n2} is {result}");
                            break;
                        }
                    case 3:
                        {
                            int result = Mul(n1, n2);
                            Console.WriteLine($"\nThe Multiplication of {n1} and {n2} is {result}");
                            break;
                        }
                    case 4:
                        {
                            int result = Div(n1, n2);
                            Console.WriteLine($"\nThe Division of {n1} and {n2} is {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nSorry....!!!!\nPlease Select the Right Option");
                            goto again;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

