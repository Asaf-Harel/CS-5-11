using System;
namespace Application
{
    public class Candidate
    {
        private string firstName;
        private string lastName;
        private int number;

        public Candidate() { }

        public string FullName() { return firstName + lastName; }
    }
}
