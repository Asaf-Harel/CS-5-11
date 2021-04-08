using System;
namespace Application
{
    public class HtmlElements
    {
        private HtmlElement[,] pages = new HtmlElement[10, 100]; // מערך של 10 עמודים עם 100 שורות

        public HtmlElements() {}

        /// <summary>מקבלת מזהה ומספר עמוד וסופרת כמה פעמים הוא מופיע שם</summary>
        /// <param name="id">מזהה</param>
        /// <param name="pageNum">מספר עמוד</param>
        /// <returns>כמה פעמים המזהה הופיע</returns>
        public int HowManyIDs(string id, int pageNum)
        {
            int countIDs = 0;
            pageNum -= 1;

            for (int i = 0; i < pages.GetLength(1); i++)
            {

                if (pages[pageNum, i].GetId() == id)
                    countIDs++;
                if (pages[pageNum, i].IsLastInPage())
                    return countIDs;
   
            }
            return countIDs;
        }

        /// <summary>בודקת אם בעמוד מסויים יש מזהה שמופיע יותר מפעם אחת</summary>
        /// <param name="pageNum">מספר עמוד</param>
        /// <returns>true - אם יש מזהה שמופיע יותר מפעם אחת | false - אם אין</returns>
        public bool DoesMoreThanOneElem(int pageNum)
        {
            pageNum -= 1;

            for (int i = 0; i < pages.GetLength(1); i++)
            {
                if (HowManyIDs(pages[pageNum, i].GetId(), pageNum + 1) > 1)
                    return true;
                if (pages[pageNum, i].IsLastInPage())
                    return false;
            }
            return false;
        }
    }
}
