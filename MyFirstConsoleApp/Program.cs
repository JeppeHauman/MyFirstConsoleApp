using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            class1.Name = "Jeppe";
            class1.Age = 25;

            Console.WriteLine(class1.Name);
            Console.WriteLine(class1.Age);
        }
    }
}
