using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class TriQueue
        {
            private Queue<int> q0, q1, q2;

            public TriQueue()
            {
                q0 = new Queue<int>();
                q1 = new Queue<int>();
                q2 = new Queue<int>();
            }

            public TriQueue(Queue<int> q0, Queue<int> q1, Queue<int> q2)
            {
                this.q0 = q0;
                this.q1 = q1;
                this.q2 = q2;
            }

            public void MoveNumber_FromQ0() { }
            public void MoveNumber_FromQ2() { }

            public void MoveNumber_FromQ1_Mod3()
            {
                int n = this.q1.Remove();

                if (n % 3 == 0)
                    this.q0.Insert(n);
                else if (n % 3 == 1)
                    this.q1.Insert(n);
                else
                    this.q2.Insert(n);
            }

            public void FixMod3()
            {
                this.q1.Insert(-1);

                while (!this.q0.IsEmpty())
                    MoveNumber_FromQ0();

                while (!this.q2.IsEmpty())
                    MoveNumber_FromQ2();

                while (!this.q1.IsEmpty() && this.q1.Head() != -1)
                {
                    MoveNumber_FromQ1_Mod3();
                }
            }
        }
    }
}
