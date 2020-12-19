using System;
namespace Application
{
    public class BikeModel
    {
        private BikeType type = new BikeType();
        private string company, model;
        private int weight, inStock;

        public bool IsQuiteHeavy()
        {
            if (weight > 30)
                return true;
            else if (weight >= 15 && !BikeType.GetIsElect())
                return true;
            else
                return false;

        }
    }
}
