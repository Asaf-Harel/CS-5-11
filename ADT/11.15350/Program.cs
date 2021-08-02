using System;

namespace Application
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

            Console.WriteLine(IsTritet(first));
        }

        /// <summary>בודקת אם יש רצף מתולתת</summary>
        /// <param name="p">רשימה</param>
        /// <returns>true - אם הרשימה מתולתת | False - אם הרשימה לא מתולתת</returns>
        static bool IsTritet(Node<int> p)
        {
            int countSequnce = 0;

            while (p != null)
            {
                if (!IsSequence(ref p, countSequnce % 3))
                    return false;

                countSequnce++;
            }
            return true;
        }

        /// <summary>בודקת אם יש רצף של שארית</summary>
        /// <param name="p">רשימה</param>
        /// <param name="n">שארית</param>
        /// <returns>true - אם יש רצף | false - אם אין</returns>
        static bool IsSequence(ref Node<int> p, int n)
        {
            int x;
            int counter = 0;

            while (p != null)
            {
                x = p.GetValue();

                if (x % 3 != n)
                {
                    return counter >= 1;
                }

                counter++;
                p = p.GetNext();
            }
            return true;
        }
    }
}
