using System;
namespace Application
{
    public class Elections
    {
        private Party[] parties = new Party[12];
        int partiesCount = 0;

        public Elections() {}

        public void AddVote(string name)
        {
            for (int i = 0; i < partiesCount; i++)
            {
                if (parties[i].GetName() == name)
                {
                    parties[i].SetVotes(parties[i].GetVotes() + 1);
                    break;
                }
            }
        }

        public void ShowLast()
        {
            int min = 0;
            Party last = parties[0];

            for (int i = 1; i < partiesCount; i++)
            {
                if (parties[i].GetVotes() < min)
                {
                    last = parties[i];
                    min = parties[i].GetVotes();
                }
            }

            last.ShowKCandidates(10);
        }
    }
}
