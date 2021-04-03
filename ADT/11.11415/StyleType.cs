using System;
namespace Application
{
    public class StyleType
    {
        private string name;
        private string style;

        public StyleType()
        {
        }

        public string GetName() { return name; }
        public string GetStyle() { return style; }

        /// <summary>סופרת כמה מאפיינים יש בסגנון העיצוב</summary>
        /// <returns>כמה מאפיינים יש</returns>
        public int CountStyleProp()
        {
            int counter = 0;

            for (int i = 0; i < style.Length; i++)
            {
                if (style[i] == ';')
                    counter++;
            }
            return counter;
        }

    }
}
