using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Get stack with the numbers of positive even negative odd sequences
        // הנחה - המחסנית אותחלה
        static Stack<int> GetPenoSequences(Stack<int> s)
        {
            int first, second, counter = 0;

            bool flag = false; // Indicate if sequence is finished

            Stack<int> newStack = new Stack<int>();

            while (!s.IsEmpty())
            {
                first = s.Pop();

                if (!s.IsEmpty())
                {
                    second = s.Top();

                    if (IsPE(first) && IsNO(second))
                    {
                        counter++;
                        flag = true;
                        s.Pop();
                    }
                    else
                    {
                        if (flag)
                        {
                            newStack.Push(counter);
                            counter = 0;
                        }
                    }

                }
            }

            return newStack;
        } 

        // Is positive and even
        static bool IsPE(int n)
        {
            return (n >= 0) && (n % 2 == 0);
        }

        // Is negative and Odd
        static bool IsNO(int n)
        {
            return (n < 0) && (n % 2 != 0);
        }
    }
}
