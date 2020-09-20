using System;
namespace ADT_HW
{
    public class Door
    {
        string model; // The door's model name
        string color; // The door's color
        bool isManualBolt; // Does the door got manual bolt?
        bool isPeephole; // Does the door got peephole?
        int lockLevel; // The lock level

        public Door()
        {
        }

        public int doorSecurityLevel()
        {
            int level = lockLevel * 7;

            if (isPeephole)
                level += 5;
            if (isManualBolt)
                level += 10;

            return level;
        }
    }
}
