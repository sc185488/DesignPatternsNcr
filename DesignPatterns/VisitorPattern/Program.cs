using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Visitor Design Pattern!");
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();

            var visitor2 = new SalesMan("John");
            school.PerformOperation(visitor2);
            Console.Read();
            
        }
    }
}
