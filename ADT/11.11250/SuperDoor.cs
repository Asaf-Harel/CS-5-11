using System;
namespace ADT_HW
{
    public class SuperDoor
    {
        Agent[] agents; // The company agents

        public SuperDoor()
        {
        }

        public void monthlySellingGoal(int goal)
        {
            int counter = 0;

            for (int i = 0; i < agents.Length; i++)
            {
                if (agents[i] != null)
                {
                    for (int j = 0; j < agents[i].getDoors().Length; j++)
                    {
                        if (agents[i].getDoors()[j] != null)
                            counter++;
                    }
                }
            }

            if (counter < goal)
                Console.WriteLine("The agents sold less then the monthly selling goal ಠ_ಠ");
            else if (counter == goal)
                Console.WriteLine("The agents sold exactly the monthly selling goal \\ (•◡•) /");
            else
                Console.WriteLine("The agents sold more than the monthly selling goal (ʘ‿ʘ)");
        }
    }
}
