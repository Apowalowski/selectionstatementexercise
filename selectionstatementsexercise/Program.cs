using System;

namespace selectionstatementsexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite number");
            int x = int.Parse(Console.ReadLine());
            if (x == 25)
            {
                Console.WriteLine("You are right!");
            }
            else if (x > 25)
            {
                Console.WriteLine("Too High.");
            }
            else 
            {
                Console.WriteLine("Too Low.");
            }
               

        }
    }
}
