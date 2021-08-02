using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void UpdateAgesCount(Node<int> p, int[] agesCount)
        {
            while (p != null)
            {
                agesCount[p.GetValue()]++;
                p = p.GetNext();
            }
        }

        static int GetCommon(int[] agesCount)
        {
            int index = 0, max = 0;

            for (int i = 0; i < agesCount.Length; i++)
            {
                if (max < agesCount[i])
                {
                    max = agesCount[i];
                    index = i;
                }
            }
            return index;
        }

        static int MostCommonAge(Node<int>[] arr)
        {
            int[] countAges = new int[121];

            for (int i = 0; i < arr.Length; i++)
            {
                UpdateAgesCount(arr[i], countAges);
            }

            return GetCommon(countAges);
        } 
    }
}
