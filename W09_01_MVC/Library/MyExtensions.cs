using System.Web.Mvc;

namespace W09_01_MVC.Library
{
    public static class MyExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id, ButtonType type, string text)
        {
            string button = string.Format("<button id = '{0}' name = '{0}' type = '{1}'> {2}</button>", id, type.ToString(), text);

                return MvcHtmlString.Create(button);
        }
    }

    public enum ButtonType
    {
        button = 0, submit = 1, reset = 2
    }
}