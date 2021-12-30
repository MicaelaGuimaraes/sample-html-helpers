using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleHTMLHelpers.Helpers
{
    public static class FileHelper
    {
        public static MvcHtmlString File(this HtmlHelper helper, string id)
        {
            return File(helper, id, null);
        }

        public static MvcHtmlString File(this HtmlHelper helper, string id, object htmlAttributes)
        {
            return BuildFileHelper(helper, id, htmlAttributes);
        }

        private static MvcHtmlString BuildFileHelper(this HtmlHelper helper, string id, object attributes)
        {
            var tag = new TagBuilder("input");
            tag.MergeAttribute("type", "file");
            tag.MergeAttribute("id", id);
            tag.MergeAttributes(new RouteValueDictionary(attributes));
            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}