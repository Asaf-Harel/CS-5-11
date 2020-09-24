using System;
namespace ADT_HW
{
    public class Agent
    {
        string name; // Agent full name
        Door[] doors; // The doors the agent sold
        int doorCounter = 0; // Count how many doors in the array

        public Agent()
        {
            doors = new Door[1000];
        }

        /**
        * <summary>
        * Check how many doors are above specific lock level
        * </summary>
        * <param name="level">The lock level</param>
        * <returns>The number of doors above the lock level</returns>
        **/
        public int doorsAboveLockLevel(int level)
        {
            int counter = 0;

            for (int i = 0; i < doorCounter; i++)
            {
                if (doors[i].getLockLevel() > level)
                    counter++;
            }

            return counter;
        }
    }
}
