using System;

namespace YouAreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(1));
            Console.WriteLine(IsSquare(25));
            Console.WriteLine(IsSquare(3));
            Console.WriteLine(IsSquare(0));
            Console.WriteLine(IsSquare(597524));
        }

        public static bool IsSquare(int n) => (Math.Floor(Math.Sqrt(n)) * Math.Floor(Math.Sqrt(n))) == n ? true : false;
        
    }
}
