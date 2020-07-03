using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prevprevNumber = 0;
            double prevNumber = 1;
            double sum = 0;
            for(double n = prevNumber; n < 4000000; n += prevprevNumber)
            {
                if(n % 2 == 0)
                {
                    sum += n;
                }
                prevprevNumber = prevNumber;
                prevNumber = n;
            }
            Console.WriteLine(sum);
        }
    }
}
