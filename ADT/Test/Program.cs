using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "";
            Node<int> first = null, last = null;
            while (true)
            {
                Console.Write("Enter a number or q to quit: ");
                s = Console.ReadLine();

                if (s == "q") { break; }

                int n = int.Parse(s);

                if (first == null)
                {
                    first = new Node<int>(n); last = first;
                }

                else
                {
                    last.SetNext(new Node<int>(n));
                    last = last.GetNext();
                }

            }

            Node<int> p = SetList(first);

            while (p != null)
            {
                Console.WriteLine(p.ToString());
                p = p.GetNext();
            }
        }

        static Node<int> SetList(Node<int> p)
        {
            Node<int> first = null, last = null;
            int x, y;

            while (p.HasNext())
            {
                x = p.GetValue();
                y = p.GetNext().GetValue();

                if (first == null)
                {
                    first = new Node<int>(x + y); last = first;
                }


                else
                {
                    last.SetNext(new Node<int>(x + y));
                    last = last.GetNext();
                }

                p = p.GetNext();
            }
            return first;
        }
    }
}
