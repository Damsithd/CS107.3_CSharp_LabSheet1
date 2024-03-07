using System;
namespace tutorial_1
{
    public class que_4
    {
        public que_4()
        {
            int number;

            Console.WriteLine("Enter value: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci series of number " + number + " is ");

            if (number == 0) Console.WriteLine(number);

            else
            {
                for (int i = 0; i < number; i++)
                {
                    int result = fib(i);
                    Console.Write(result + " ");

                }
            }

        }


        public static int fib(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return fib(num - 1) + fib(num - 2);
            }
        }
    }

}

