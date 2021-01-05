using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // מחזירה מחסנית חדשה עם הרצפים
        static Stack<string> CharAndBool(Stack<char> sC, Stack<bool> sB)
        {
            Stack<string> q = new Stack<string>();
            string seq;

            while(!sC.IsEmpty())
            {
                seq = GetSequence(sC, sB);
                if (seq != "") { q.Push(seq); }
            }

            return q;
        }

        // מחזירה את רצף התווים על פי הקריטריונים
        static string GetSequence(Stack<char> sC, Stack<bool> sB)
        {
            char c; bool prevB = false, currB = true;
            string sequence = "";
            bool isFirst = true;

            if (!sC.IsEmpty()) { prevB = sB.Pop(); }

            while (!sC.IsEmpty())
            {
                currB = sB.Pop(); c = sC.Pop();

                if (prevB && currB) {
                    if (isFirst) { sequence += c + sC.Pop(); isFirst = false; }
                    else { sequence += c; }
                }
            }

            return sequence;
        }
    }
}
