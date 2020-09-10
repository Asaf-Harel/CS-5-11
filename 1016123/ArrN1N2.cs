using System;
namespace ADTWithArray
{
    public class ArrN1N2
    {
        private int[] arr;
        private int n1, n2;

        public ArrN1N2(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;

            arr = new int[n1 + n2];

            updateArray();
        }

        private void updateArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < n1)
                {
                    arr[i] = n1;
                }
                else
                {
                    arr[i] = n2;
                }

            }
        }
    }
}
