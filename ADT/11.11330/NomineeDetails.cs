using System;
namespace Application
{
    public class NomineeDetails
    {
        int id; string lastName; string firstName; string phoneNumber; string email;

        public NomineeDetails() { }

        public void ShowDetails()
        {
            Console.WriteLine($"Details for {id}:");
            Console.WriteLine($"\tFull Name - {firstName} {lastName}");
            Console.WriteLine($"\tContact Info - {phoneNumber} | {email}");
        }
    }
}
