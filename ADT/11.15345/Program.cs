using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O(n + m)");
        }

        /// <summary>יוצרת רשימה של רצפי מחרוזות סוף שרשור</summary>
        /// <param name="p">רשימה של מחרוזות</param>
        /// <returns>רשימה של רצפי מרחרוזות סוף שרשור</returns>
        static Node<string> EndStringConcat(Node<string> p)
        {
            Node<string> first = null, last = null;
            string x_new;

            while (p != null)
            {
                x_new = GetSequence(ref p);

                if (first == null)
                {
                    first = new Node<string>(x_new);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<string>(x_new));
                    last = last.GetNext();
                }
            }
            return first;
        }

        /// <summary>מחברת רצף אחד של מרחוזת סוף שרשור</summary>
        /// <param name="p">רשימה של מחרוזות</param>
        /// <returns>מחרוזת של הרצף</returns>
        static String GetSequence(ref Node<string> p)
        {
            string seq = p.GetValue();
            string val;
            p = p.GetNext();

            while (p != null)
            {
                val = p.GetValue();
                if (seq[seq.Length - 1] == val[0])
                {
                    seq = ConcatStrings(seq, val);
                    p = p.GetNext();
                }
                else
                    return seq;
            }
            return seq;
        }

        /// <summary>מחברת שני מחרוזות</summary>
        /// <param name="s1">מחרוזת ראשונה</param>
        /// <param name="s2">מחרוזת שנייה</param>
        /// <returns>חיבור של שתי המחרוזות</returns>
        static string ConcatStrings(string s1, string s2)
        {
            for (int i = 1; i < s2.Length; i++)
            {
                s1 += s2[i];
            }
            return s1;
        }
    }
}
