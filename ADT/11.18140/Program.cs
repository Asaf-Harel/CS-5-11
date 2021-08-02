using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static Queue<string> GetSequenceList(Node<Item> p)
        {
            Queue<string> q = new Queue<string>();
            string 

            while (p != null)
            {
                if
            }
        }

        static bool FindSequence(ref Node<Item> p1, ref Node<Item> p2)
        {
            if (p1 == null || p2 == null)
            {
                Item first = p1.GetValue(), second = p2.GetValue();

                if (GetRightDigit(first.GetNumber()) == GetLeftDigit(second.GetNumber()))
                    return true;
            }
            return false;
        }

        static int GetRightDigit(int n)
        {
            return n % 10;
        }

        static int GetLeftDigit(int n)
        {
            while (n  > 10)
            {
                n /= 10;
            }
            return n;
        }
    }

    class Item
    {
        private int number; private char letter;

        public int GetNumber() { return number; }
        public char GetLetter() { return letter; }
    }
}
