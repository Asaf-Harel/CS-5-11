using System;
namespace Application
{
    public class Nominee
    {
        NomineeDetails details = new NomineeDetails();
        NomineeVolunteer nomineeVolunteer = new NomineeVolunteer();
        SubjectGrade[] subjects = new SubjectGrade[15];
        int gradesCounter = 0;

        public Nominee() { }

        public double FinalsAverage()
        {
            double sum = 0;

            for (int i = 0; i < gradesCounter; i++)
            {
                sum += subjects[i].GetGrade();
            }

            return sum / gradesCounter;
        }
    }
}
