using System;
namespace tutorial_1
{
    public class que_5
    {
        public que_5()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            if (num < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine(num + " x " + i + " = " + result);
                }
            }

            Console.ReadLine();
        }
    }
}

