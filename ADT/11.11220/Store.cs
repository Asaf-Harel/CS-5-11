using System;
namespace ADT_HW2
{
    public class Store
    {
        private string name; // The name of the store
        private int area; // The area of the store (in square meters)
        private int rent; // The rental cost
        private bool isPaid; // Does the rent was already paid for the last month;

        public Store(string name, int area, int rent, bool isPaid)
        {
            this.name = name;
            this.area = area;
            this.rent = rent;
            this.isPaid = isPaid;
        }

        /**
         * <summary>
         * Calculate the store's rent per meter
         * </summary> 
         * <returns>The sqare root of the rent</returns>
         **/
        public double CostForMeter()
        {
            return Math.Sqrt(rent);
        }

    }
}
