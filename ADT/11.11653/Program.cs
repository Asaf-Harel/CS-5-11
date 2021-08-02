using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Race
    {
        private Node<Competitor> competitors;

        public void Add(Competitor x)
        {
            competitors.SetNext(new Node<Competitor>(x));
        }

        public string Rank(int x)
        {
            Node<Competitor> p = competitors;
            Competitor c = p.GetValue();

            int place = 1;

            while(p != null)
            {
                c = p.GetValue();

                if (place == x)
                    return c.GetName();

                p = p.GetNext();
                place++;
            }
            return c.GetName();
        }
    }

    class Competitor
    {
        private int minutes;
        private int seconds;
        private string name;

        public string GetName() { return name; }
    }
}
