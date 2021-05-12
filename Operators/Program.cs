using System;


namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 27;
            var b = 3;
            var c = 17;
            var d = 2;
            
            // added by abhishek.
            Console.WriteLine(a+b/d-c);
            Console.WriteLine(a > b); Console.WriteLine(a!=c);
            Console.WriteLine((float)c/(float)d);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);

        }
    }
}
