using System.Text;
using System.Web.Mvc;

namespace MvcApplication1.Helpers {
    public static class ListHelper {

        public static MvcHtmlString List(this HtmlHelper helper, string[] items) {
            // Create string builder to efficiently build up a string
            var sb = new StringBuilder();

            // Create opening UL
            sb.AppendLine("<ul>");

            // Loop through items and create LI for each item
            foreach (var item in items) {
                sb.AppendFormat("<li>{0}</li>", item);
            }

            // Create closing UL
            sb.AppendLine("</ul>");

            // Return string as MvcHtmlString
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}