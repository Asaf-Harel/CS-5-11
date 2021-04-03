using System;

namespace _11._14240
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Waiting> q = new Queue<Waiting>();
            Queue<int> q2 = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                q.Insert(new Waiting(rnd.Next(0, 3), true));
            }
            q2 = ValidQueue(q);
            Console.WriteLine(q2.ToString());
        }

        static Queue<int> ValidQueue(Queue<Waiting> q)
        {
            Queue<int> q2 = new Queue<int>();
            int seq;

            while (!q.IsEmpty())
            {
                seq = ValidSeq(q);

                if (seq > 0)
                    q2.Insert(seq);
            }
            return q2;
        }

        static int ValidSeq(Queue<Waiting> q)
        {
            int countValid = 0;
            Waiting w;

            while (!q.IsEmpty())
            {
                w = q.Head();

                if ((w.GetDfHead() >= 2.0) && w.GetHasMask())
                    countValid++;
                else
                    return countValid;

                q.Remove();
            }
            return countValid;
        }
    }
}
