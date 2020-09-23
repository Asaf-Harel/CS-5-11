using System;
namespace ADT_HW
{
    public class FireDanger
    {
        private int windSpeed; // The wind speed in km/h
        private int humidityLevel; // Humidity level in precentage
        private int degrees; // Degress in fahrenheit

        public FireDanger(int windSpeed, int humidityLevel, int degrees)
        {
            this.windSpeed = windSpeed;
            this.humidityLevel = humidityLevel;
            this.degrees = degrees;
        }

        public int DangerRate()
        {
            int rate = 0;

            if (70 < windSpeed)
            {
                rate++;
            }
            if (humidityLevel < 30)
            {
                rate += 2;
            }
            else if (humidityLevel < 50)
            {
                rate++;
            }
            if (100 < degrees)
            {
                rate += (degrees - 100) / 10;
            }

            if (rate == 0)
            {
                rate = 0;
            }

            return Math.Min(rate, 5);
        }
    }
}
