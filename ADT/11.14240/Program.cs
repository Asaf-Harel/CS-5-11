using System;

namespace Application
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O(n)");
        }

        /// <summary>בודקת את כל הרצפים של תורים תקינים</summary>
        /// <param name="q">תור של אנשים</param>
        /// <returns>תור של כל הרצפים של תורים תקינים</returns>
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

        /// <summary>בודקת את מספר האנשים בתור תקין</summary>
        /// <param name="q">תור של אנשים</param>
        /// <returns>מספר האנשים בתור תקין</returns>
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
                {
                    q.Remove();
                    return countValid;
                }

                q.Remove();
            }
            return countValid;
        }
    }
}
