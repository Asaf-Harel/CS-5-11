using System;
namespace ADT_HW
{
    public class Job
    {
        private string employer; // Employer name
        private int hoursPerWeek; // The hours per week the teacher worked
        private bool isPermanent; // Does the teacher permanent in the school

        public Job(string employer, int hoursPerWeek, bool isPermanent)
        {
            this.employer = employer;
            this.hoursPerWeek = hoursPerWeek;
            this.isPermanent = isPermanent;
        }

        public bool getIsPermanent()
        {
            return isPermanent;
        }

        public string getEmployer()
        {
            return employer;
        }

        public int getHoursPerWeek()
        {
            return hoursPerWeek;
        }
    }
}
