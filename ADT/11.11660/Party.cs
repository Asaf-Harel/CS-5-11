using System;
namespace Application
{
    public class Party
    {
        private string name;
        private Candidate chairman;
        private Node<Candidate> candidates;
        private int votes;

        public Party() {}

        public string GetName() { return name; }
        public int GetVotes() { return votes; }
        public void SetVotes(int votes) { this.votes = votes; }

        public void ShowKCandidates(int k)
        {
            Console.WriteLine(chairman.FullName());
            k -= 1;

            Node<Candidate> p = candidates;
            while(k != 0)
            {
                if (p == null)
                    Console.WriteLine("Not enough candidates :(");
                else
                {
                    Console.WriteLine(p.GetValue().FullName());
                    p = p.GetNext();
                    k -= 1;
                }
            }
        }
    }
}
