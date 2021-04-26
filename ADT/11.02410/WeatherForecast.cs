using System;
namespace Application
{
    public class WeatherForecast
    {
        int temp;
        int humdity;

        public WeatherForecast() { }

        /// <summary>מחזירה את רמת החום</summary>
        public int TempLevel()
        {
            if (temp < 22)
                return 0;
            else if (temp > 22 && temp < 25)
                return 1;
            else if (temp > 25 && temp < 30)
                return 2;
            else
                return 3;
        }

        /// <summary>מחזירה את רמת החום בהתאם ללחות</summary>
        public int TempLevelHu()
        {
            if (humdity > 75)
            {
                if (TempLevel() < 3)
                    return TempLevel() + 1;
            }
            return TempLevel();
        }
    }
}
