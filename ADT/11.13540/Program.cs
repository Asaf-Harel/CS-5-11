using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(5); s.Push(2); s.Push(4); s.Push(6); s.Push(1);

            Console.WriteLine(ECO(s));
        }

        // Element Change Order
        // הנחה - המחסנית מאותחלת
        static Stack<int> ECO (Stack<int> s)
        {
            int prev = 0, curr, next, counter = 0;

            Stack<int> newStack = new Stack<int>();

            while (!s.IsEmpty())
            {
                prev = s.Pop();

                if (!s.IsEmpty())
                {
                    curr = s.Top();
                    next = GetNext(s, curr);

                    if (IsChanged(prev, curr, next))
                        newStack.Push(curr);

                }
            }

            return newStack;
        }

        // מחזירה את האיבר הבא
        static int GetNext(Stack<int> s, int elem)
        {

            while (!s.IsEmpty())
            {
                if (s.Pop() == elem)
                {
                    if (!s.IsEmpty())
                    {
                        return s.Top();
                    }
                }
            }
            return 0;
        }

        // בודקת אם השתנה הסדר בין המספר הנוכחי לקודם והבא
        static bool IsChanged(int prev, int curr, int next)
        {
            if ((prev > curr) && (curr > prev))
                return false;
            else if ((prev < curr) && (curr < next))
                return false;
            else
                return true;
        }
    }
}
