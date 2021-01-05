using System;
namespace Application
{
    public class ClipRate
    {
        private int id;
        private int qualityRate, relevantRate, intrestRate;
        private string phoneNum;

        public ClipRate(int id, int qualityRate, int relevantRate, int intrestRate, string phoneNum)
        {
            this.id = id; this.qualityRate = qualityRate; this.relevantRate = relevantRate; this.intrestRate = intrestRate;
            this.phoneNum = phoneNum;
        }

        public double RateAvg()
        {
            return (qualityRate + relevantRate + intrestRate) / 3.0;
        }
    }
}
