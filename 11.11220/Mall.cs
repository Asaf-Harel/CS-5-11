using System;
namespace ADT_HW2
{
    public class Mall
    {
        Store[] stores; // Array of the stores

        public Mall(Store[] stores)
        {
            this.stores = stores;
        }

        /**
         * <summary>
         * Check if a store exists in the mall
         * </summary>
         * <param name="name">The store's name</param>
         * <returns>True if the store exist, else - false</returns>
         **/
        public bool IsExist(string name)
        {
            for (int i = 0; i < stores.Length; i++)
            {
                if (stores[i] != null)
                {
                    if (stores[i].getName() == name)
                        return true;
                }
            }
            return false;
        }

        /**
         * <summary>
         * Check if most of the stores already paid the rent for the last month
         * </summary>
         * <returns>True if most of the stores paid, else - false</returns>
         **/
        public bool AreMorePaid()
        {
            int totalStores = 0;
            int paidCounter = 0;

            for (int i = 0; i < stores.Length; i++)
            {
                if (stores[i] != null)
                {
                    totalStores++;

                    if (stores[i].getIsPaid())
                        paidCounter++;
                }
            }

            if ((totalStores / 2) < paidCounter)
            {
                return true;
            }
            return false;

        }
    }
}
