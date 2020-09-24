using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] a = new int[3, 4];
            a[1, 0] = 2;
            Console.WriteLine(a.GetLength(0));

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }

    }
}
