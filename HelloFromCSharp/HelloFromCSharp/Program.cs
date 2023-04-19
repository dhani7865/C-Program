using System;

namespace HelloFromCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everybody!");

            Console.WriteLine("Please enter your Firstname: ");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your lastName: ");
            String lastName = Console.ReadLine();

            // Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello " + FirstName + " " + lastName);

        }
    }
}
