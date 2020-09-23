using System;

namespace ADT_HW
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ...
        }

        public static string StateDangerRate(Countie[] counties)
        {

            int veryHighCounter = 0;
            int highCounter = 0;

            bool isVeryHigh = false;

            for (int i = 0; i < counties.Length; i++)
            {
                FireDanger[] daysDanger = counties.GetNextFiveDays();


                for (int j = 0; j < daysDanger.Length; j++)
                {
                    if (daysDanger[i].DangerRate() == 5)
                        isVeryHigh = true;

                    else if ((2 < daysDanger[i].DangerRate()) && !(isVeryHigh))
                        isVeryHigh = false;
                }

                if (isVeryHigh)
                    veryHighCounter++;
                else
                    highCounter++;
            }

            if ((int)(counties.Length * (1.0/3.0)) <= veryHighCounter)
            {
                return "Very high! :(";
            }

            else if ((int)(counties.Length * (1.0/5.0)) <= highCounter)
            {
                return "High... :/";
            }

            else
            {
                return "Low :)";
            }

        }
    }
}
