using System;
namespace ADT_HW
{
    public class Agent
    {
        string name; // Agent full name
        Door[] doors; // The doors the agent sold

        public Agent()
        {
        }

        public int doorsAboveLockLevel(int level)
        {
            int counter = 0;

            for (int i = 0; i < doors.Length; i++)
            {
                if (doors[i] != null)
                {
                    if (doors[i].getLockLevel() < level)
                        counter++;
                }
            }

            return counter;
        }
    }
}
