using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O(n)!!!!");
        }


        static Node<double> GetZigZagSeq(Node<int> p)
        {
            Node<double> first = null, last = null;
            double x_new;

            while (p != null)
            {
                x_new = CountZigZag(ref p);
                if (x_new != 0)
                {
                    if (first == null)
                    { first = new Node<double>(x_new); last = first; }
                    else
                    { last.SetNext(new Node<double>(x_new)); last = last.GetNext(); }
                }
            }
            return first;
        }


        static double CountZigZag(ref Node<int> p)
        {
            int x = p.GetValue(), countSeq = 0, sum = 0;
            bool last = false;

            if (p != null)
            {
                last = x < 0;
                sum += Math.Abs(x);
                countSeq++;
                p = p.GetNext();
            }
            while (p != null)
            {
                x = p.GetValue();
                if ((x < 0) != last)
                {
                    last = x < 0;
                    sum += Math.Abs(x);
                    countSeq++;
                    p = p.GetNext();
                }
                else
                {
                    return (double)sum / countSeq;
                }
            }
            return (double)sum / countSeq;
        }
    }
}
