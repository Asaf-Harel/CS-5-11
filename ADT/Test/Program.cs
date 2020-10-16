using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Item item1 = new Item("abc", 'a');
            Item item2 = new Item("abc", 'b');
            Item item3 = new Item("bc", 'c');
            Item item4 = new Item("bc", 'a');
            Item item5 = new Item("c", 'd');
            Item item6 = new Item("d", 'c');

            Item[] items = { item1, item2, item3, item4, item5, item6 };

            Console.WriteLine(WWW(items, 0));
        }

        static bool WWW(Item item1, Item item2)
        {
            return WWW(item1, 0) == WWW(item2, 0);
        }

        static bool WWW(Item item, int i)
        {
            if (i == item.GetStr().Length)
                return false;
            else if (item.GetStr()[i] == item.GetChr())
                return true;
            else
                return WWW(item, i + 1);

        }

        static int WWW(Item[] items, int i)
        {
            if (i == items.Length - 1 || i == items.Length)
                return 0;
            else if (WWW(items[i], items[i + 1]))
                return 1 + WWW(items, i + 2);
            else
                return WWW(items, i + 2);
        }

    }

    class Item
    {
        private string str;
        private char chr;

        public Item(string s, char c) {
            str = s;
            chr = c;
        }

        public string GetStr() { return str; }
        public char GetChr() { return chr; }
    }
}
