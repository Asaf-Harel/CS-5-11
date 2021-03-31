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

            Node<int> p = SequenceList(first);
            while (p != null)
            {
                Console.Write($"| {p.ToString()} ");
                p = p.GetNext();
            }
            Console.Write("|");
            Console.WriteLine();
        }

        /** <summary>יוצרת רשימת רצפים</summary> **/
        static Node<int>SequenceList(Node<Node<int>>p)
        {
            Node<int> first = null, last = null; int x_new;
            while (p != null)
            {
                x_new = CountSequenceList(ref p);
                if (x_new != 0)
                {
                    if (first == null)
                    { first = new Node<int>(x_new); last = first; }
                    else
                    { last.SetNext(new Node<int>(x_new)); last = last.GetNext(); }
                }
            }
            return first;
        }

        /** <summary>סופרת את הרצף</summary> **/
        static int CountSequenceList(ref Node<Node<int>> p)
        {
            int count = 0;
            Node<int> p1, p2;

            while (p.HasNext())
            {
                p1 = p.GetValue();
                p = p.GetNext();
                p2 = p.GetValue();
                if (CountList(p1) == CountList(p2))
                {
                    count++;
                    p = p.GetNext();  
                }
                else
                {
                    p = p.GetNext();
                    return count;
                }
            }
            return count;
        }

        /** <summary>סופרת את אורך הרשימה</summary> **/
        static int CountList(Node<int> p)
        {
            int counter = 0;

            while (p != null)
            {
                counter++;
                p = p.GetNext();
            }

            return counter;
        }
    }
}

/*
            string s = "";
            Node<string> first = null, last = null;
            while (true)
            {
                Console.Write("Enter a string or q to quit: ");
                s = Console.ReadLine();

                if (s == "q") { break; }

                string n = s;

                if (first == null)
                {
                    first = new Node<string>(n); last = first;
                }

                else
                {
                    last.SetNext(new Node<string>(n));
                    last = last.GetNext();
                }
            }

            Node<string> p = EndStringConcat(first);
            while (p != null)
            {
                Console.Write($"| {p} ");
                p = p.GetNext();
            }
            Console.Write("|");
            Console.WriteLine();
 */
