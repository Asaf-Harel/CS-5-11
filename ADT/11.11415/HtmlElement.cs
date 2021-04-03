using System;
namespace Application
{
    public class HtmlElement
    {
        private string id;
        private StyleType styleType;
        private bool isLastInPage;

        public HtmlElement()
        {
        }

        public string GetId() { return id; }
        public StyleType GetStyleType() { return styleType; }
        public bool IsLastInPage() { return isLastInPage; }

    }
}
