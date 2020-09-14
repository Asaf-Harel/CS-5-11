using System;
namespace ADT_HW
{
    public class Countie
    {
        private string name; // Countie name
        private FireDanger[] nextFiveDays; // Fire danger on the next 5 days

        public Countie(string name, FireDanger[] nextFiveDays)
        {
            this.name = name;
            this.nextFiveDays = nextFiveDays;
        }

        public bool IsDangerDay()
        {
            for (int i = 0; i < 5; i++)
            {
                if (3 <= nextFiveDays[i].DangerRate())
                    return true;
            }
            return false;
        }
    }
}
