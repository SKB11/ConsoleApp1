using System;
namespace program
{
    class Add
    {
        static void Main()
        {
            int n1, n2, sum;

            Console.WriteLine("Enter the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            sum = n1 + n2;

            Console.WriteLine("The sum of {0} and {1} is {2}", n1, n2, sum);

            //Console.ReadKey();
        }
    }
}

