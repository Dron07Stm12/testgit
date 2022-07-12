using System;

namespace ConsoleGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a +" "+ Class1.Foo(a));
            Console.WriteLine("Hello World!");
        }
    }
}
