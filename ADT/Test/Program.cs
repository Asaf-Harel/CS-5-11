using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Node<int> p = new Node<int>(3240);
            Node<int> p2 = new Node<int>(536);
            Node<int> p3 = new Node<int>(55);
            //Node<int> p4 = new Node<int>(274);
            //Node<int> p5 = new Node<int>(234);
            p.SetNext(p2); p2.SetNext(p3);// p3.SetNext(p4); p4.SetNext(p5);

            Console.WriteLine(MaxDiff(p));
        }

        static int SumDigitsDiff(int n)
        {
            int sum = 0;
            int prev = n % 10;
            n /= 10;
            int curr = 0;

            while (n > 0)
            {
                curr = n % 10;
                sum += Math.Abs(prev - curr);
                prev = curr;
                n /= 10;
            }
            return sum;
        }

        static int NodesDiff(Node<int> p1, Node<int> p2)
        {
            int x1 = p1.GetValue(), x2 = p2.GetValue();
            return Math.Abs(SumDigitsDiff(x1) - SumDigitsDiff(x2));

        }

        static int MaxDiff(Node<int> p)
        {
            int max = 0;

            while(p != null)
            {
                if (p.HasNext())
                {
                    if (max < NodesDiff(p, p.GetNext()))
                        max = NodesDiff(p, p.GetNext());
                }
                p = p.GetNext();
            }
            return max;
        }
    }
}
