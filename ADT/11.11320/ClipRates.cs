using System;
namespace Application
{
    public class ClipRates
    {
        private ClipRate[] rates = new ClipRate[10000];
        private int countUserRates = 0;
        
        public ClipRates() { }

        public int CountRates(int id)
        {
            int counter = 0;

            for (int i = 0; i < countUserRates; i++)
            {
                if (rates[i].GetId() == id)
                    counter++;
            }

            return counter;
        }

        public string UserWin()
        {
            Random rnd = new Random();
            int i = rnd.Next(countUserRates);

            return rates[i].GetPhoneNum();
        }

        public void TopVideos()
        {
            int appear = 0;
            bool isGood = false;

            for (int i = 0; i < countUserRates; i++)
            {
                for (int j = 0; j < countUserRates; j++)
                {
                    if (rates[i] == rates[j]) {
                        appear++;
                        if (!isGood)
                            isGood = rates[i].RateAvg() == 5.0;
                    }
                }

                if (isGood && (4 <= appear))
                    Console.WriteLine("Winner - " + rates[i].GetId());
            }
        }
    }
}
