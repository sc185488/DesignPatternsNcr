using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Observer Design Pattern!");
            //Create a Product with Out Of Stock Status
            Subject OnePlus = new Subject("OnePlus Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Maharshi", OnePlus);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Nagarjuna", OnePlus);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Krishna", OnePlus);

            Console.WriteLine("OnePlus Mobile current state : " + OnePlus.getAvailability());
            Console.WriteLine();
            // Now product is available
            OnePlus.setAvailability("Available");
            Console.Read();
        }
    }
}
