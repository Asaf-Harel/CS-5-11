using System;
namespace Application
{
    public class Shop
    {
        private BikeModel[] modelsArr = new BikeModel[50];
        private int countBikes = 0;

        public int CountBicycle(string company, string typeName)
        {
            int count = 0;

            for (int i = 0; i < countBikes; i++)
            {
                if (modelsArr[i].GetCompany() == company && modelsArr[i].GetBikeType().GetType() == typeName)
                    count += modelsArr[i].GetInStock();
            }

            return count;
        }

        public void PNotQHEBInS()
        {
            for (int i = 0; i < countBikes; i++)
            {
                if (modelsArr[i].GetBikeType().GetIsElect() && !modelsArr[i].IsQuiteHeavy() && modelsArr[i].GetInStock() > 0)
                    Console.WriteLine(modelsArr[i].GetModel());
            }
        }
    }
}
