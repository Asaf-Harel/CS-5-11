using System;
namespace ADT_HW
{
    public class Teacher
    {
        // Personal Details
        private string id; // Teacher's ID
        private string lastName; // Teacher's last name
        private string firstName; // Teacher's first name
        private int birthYear; // Teacher's birth year

        // Job Details
        Job jobDetails; // Teacher's job deatils

        public Teacher(string id, string lastName, string firstName, int birthYear, Job jobDetails)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.birthYear = birthYear;
            this.jobDetails = jobDetails;
        }

        public int getBirthYear()
        {
            return birthYear;
        }

        public bool isPermanent()
        {
            return jobDetails.getIsPermanent();
        }

        public string employerName()
        {
            return jobDetails.getEmployer();
        }

        public string jobType()
        {
            if (55 < DateTime.Now.Year - birthYear)
            {
                if (20 <= jobDetails.getHoursPerWeek())
                {
                    return "Full time job";
                }
                else
                {
                    return "Part time job";
                }
            }
            else if ((50 < DateTime.Now.Year - birthYear) && (DateTime.Now.Year - birthYear < 55))
            {
                if (22 <= jobDetails.getHoursPerWeek())
                {
                    return "Full time job";
                }
                else
                {
                    return "Part time job";
                }
            }
            else if (50 <= DateTime.Now.Year - birthYear)
            {
                if (24 <= jobDetails.getHoursPerWeek())
                {
                    return "Full time job";
                }
                else
                {
                    return "Part time job";
                }
            }
            return "";
        }
    }
}
