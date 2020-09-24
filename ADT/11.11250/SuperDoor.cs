using System;
namespace ADT_HW
{
    public class SuperDoor
    {
        Agent[] agents; // The company agents
        int agentsCounter = 0; // The number of agents in superdoor

        public SuperDoor()
        {
            agents = new Agent[20];
        }

        /**
        * <summary>
        * Check if the agents meet the selling goal and show the result
        * </summary>
        * <param name="goal">The selling goal</param>
        **/
        public void monthlySellingGoal(int goal)
        {
            int counter = 0;

            for (int i = 0; i < agentsCounter; i++)
            {
                counter += agents[i].getDoorsCounter();
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
