using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1; 
            while (n <= 200)
            {
                Console.WriteLine($"Hello world, for {n} times");
                n++;
            }
            Console.ReadLine();
        }
    }
}
