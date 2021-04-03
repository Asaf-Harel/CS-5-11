using System;
namespace Application
{
    public class HtmlElements
    {
        private HtmlElement[] htmlElements = new HtmlElement[1000]; // מערך של 1000 אלמנטים (10 עמודים כפול 100 שורות)

        public HtmlElements() {}

        /// <summary>מקבלת מזהה ומספר עמוד וסופרת כמה פעמים הוא מופיע שם</summary>
        /// <param name="id">מזהה</param>
        /// <param name="pageNum">מספר עמוד</param>
        /// <returns>כמה פעמים המזהה הופיע</returns>
        public int HowManyIDs(string id, int pageNum)
        {
            pageNum = (pageNum - 1) * 100;
            int countIDs = 0;

            for (int i = pageNum; i < pageNum + 100; i++)
            {
                if (htmlElements[i].GetId() == id)
                    countIDs++;
            }
            return countIDs;
        }

        /// <summary>בודקת אם בעמוד מסויים יש מזהה שמופיע יותר מפעם אחת</summary>
        /// <param name="pageNum">מספר עמוד</param>
        /// <returns>true - אם יש מזהה שמופיע יותר מפעם אחת | false - אם אין</returns>
        public bool DoesMoreThanOneElem(int pageNum)
        {
            int modifiedPageNum = (pageNum - 1) * 100;

            for (int i = modifiedPageNum; i < modifiedPageNum + 100; i++)
            {
                if (HowManyIDs(htmlElements[i].GetId(), pageNum) > 1)
                    return true;
            }
            return false;
        }
    }
}
