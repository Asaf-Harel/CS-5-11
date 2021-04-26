using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static Node<int> IndexSequence(Node<Node<int>> p)
        {
            Node<int> first = null, last = null;
            int x;

            while (p != null)
            {
                x = SequenceLength(p.GetValue());

                if (first == null) { first = new Node<int>(x); last = first; }
                else { last.SetNext(new Node<int>(x)); last = last.GetNext(); }

                p = p.GetNext();
            }
            return first;
        }

        static int SequenceLength(Node<int> p)
        {
            int x, index = 1, counter = 0;

            while (p != null)
            {
                x = p.GetValue();

                if (SumDigits(x) > SumDigits(index))
                    counter++;

                p = p.GetNext();
                index++;
            }
            return counter;
        }

        static int SumDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
