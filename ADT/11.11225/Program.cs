using System;

namespace ADT_HW
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string StateDangerRate(Countie[] counties)
        {
            int veryHighCounter = 0;
            int highCounter = 0;

            for (int i = 0; i < counties.Length; i++)
            {

                if (counties[i].DangerRate() == 5)
                {
                    veryHighCounter++;
                }
                else if (2 < counties[i].DangerRate())
                {
                    highCounter++;
                }
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
