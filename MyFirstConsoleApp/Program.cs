using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.Name = "Jeppe";

            Console.WriteLine(class1.Name);
        }
    }
}
