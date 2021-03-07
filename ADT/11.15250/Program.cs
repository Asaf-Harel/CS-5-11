using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Node<StudentSleep> first = null, last = null;
            int h, g, n;
            StudentSleep s;

            for (int i = 0; i < 20; i++)
            {
                h = rnd.Next(1, 15);
                g = rnd.Next(10, 13);
                n = rnd.Next(1, 8);
                s = new StudentSleep(h, g, n);

                if (first == null)
                {
                    first = new Node<StudentSleep>(s);
                    last = first;
                }
                else
                {
                    last.SetNext(new Node<StudentSleep>(s));
                    last = last.GetNext();
                }
            }
           
            NeedToSleep(first);
        }

        static void NeedToSleep(Node<StudentSleep> p)
        {
            for (int i = 10; i <= 12; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (!IsGoodSleep(p, i, j))
                        Console.WriteLine($"{i}-{j} need lecture");
                }
            }
        }

        static bool IsGoodSleep(Node<StudentSleep> p, int grade, int num)
        {
            StudentSleep x;
            int goodCounter = 0;
            int total = 0;

            while (p != null)
            {
                x = p.GetValue();
                if ((x.GetGrade() == grade) && (x.GetNum() == num))
                {
                    if (x.IsGoodSleep())
                        goodCounter++;
                    total++;
                }
                p = p.GetNext();
            }
            return (total / 2) <= goodCounter;
        }
    }
}
