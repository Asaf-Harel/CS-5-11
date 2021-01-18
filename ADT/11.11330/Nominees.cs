using System;
namespace Application
{
    public class Nominees
    {
        Nominee[] nominees = new Nominee[1000];
        int nominessCounter = 0; // Count how many nominess

        public Nominees() { }

        public void Accepted()
        {
            for (int i = 0; i < nominessCounter; i++)
            {
                if ((85 < nominees[i].FinalsAverage()) && (3 < nominees[i].GetVolunteer().Years()))
                {
                    nominees[i].GetDetails().ShowDetails();
                }
            }
        }
    }
}
