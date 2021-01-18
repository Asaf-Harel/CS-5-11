using System;
namespace Application
{
    public class NomineeVolunteer
    {
        string name; int yearStart; int yearEnd;

        public NomineeVolunteer() { }

        public int Years()
        {
            return yearEnd - yearStart;
        }
    }
}
