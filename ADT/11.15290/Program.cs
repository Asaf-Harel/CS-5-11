using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O(n^3 + m)");
        }

        /// <summary>מקבלת רשימה של מספרים ויוצרת מערך של 3 תאים כאשר בכל תא יש מספרים שהספרות שלהם לא מתחלקות בשארית האינדקס</summary>
        /// <param name="p">רשימת מספרים</param>
        /// <returns>מערך של 3 תאים כאשר בכל תא יש רשימת מספרים שהספרות שלהם לא מתחלקות בשארית האינדקס של התא</returns>
        static Node<int>[] ThreeArray(Node<int> p)
        {
            Node<int>[] arr = new Node<int>[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = ModList(p, i);
            }
            return arr;
        }

        /// <summary>מקבלת רשימת מספרים ויוצרת רשימה חדשה של המספרים שהספרות שלהם לא מתחלקות בשארית כלשהי</summary>
        /// <param name="p">רשימת מספרים</param>
        /// <param name="mod">שארית</param>
        /// <returns>רשימה של המספרים שהספרות שלהם לא מתחלקות בשארית כלשהי</returns>
        static Node<int> ModList(Node<int> p, int mod)
        {
            Node<int> first = null, last = null;
            int n;

            while (p != null)
            {
                n = p.GetValue();
                if (DivideByThree(n, mod))
                {
                    if (first == null)
                    {
                        first = new Node<int>(n);
                        last = first;
                    }
                    else
                    {
                        last.SetNext(new Node<int>(n));
                        last = last.GetNext();
                    }
                }
                p = p.GetNext();
            }
            return first;
        }

        /// <summary>מקבלת מספר ובודקת אם הספרות שלא לא מתחלקות בשארית כלשהי</summary>
        /// <param name="n">מספר</param>
        /// <param name="mod">שארית</param>
        /// <returns>true - כשהספרות לא מתחלקות בשארית | false - כשהספרות כן מתחלקות</returns>
        static bool DivideByThree(int n, int mod)
        {
            while (n > 0)
            {
                if ((n % 10) % 3 == mod)
                    return false;
                n /= 10;
            }
            return true;
        }
    }
}
