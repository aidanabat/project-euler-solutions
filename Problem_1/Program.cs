using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 3; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
