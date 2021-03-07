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
                    return;
                }
            }
        }

        public void ShowLast()
        {
            Party last = parties[0];

            for (int i = 1; i < partiesCount; i++)
            {
                if (parties[i].GetVotes() < last.GetVotes())
                    last = parties[i];
            }

            last.ShowKCandidates(10);
        }
    }
}
