using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleHTMLHelpers.Helpers
{
    public static class TagImgHelper
    {
        public static MvcHtmlString TagImg(this HtmlHelper helper, string src, string alt)
        {
            return TagImg(helper, src, alt, null);
        }

        public static MvcHtmlString TagImg(this HtmlHelper helper, string src, string alt, object htmlAttributes)
        {
            if (src == null || string.IsNullOrEmpty(src))
            {
                return MvcHtmlString.Empty;
            }

            return BuildTagImgHelper(helper, src, alt, htmlAttributes);
        }

        private static MvcHtmlString BuildTagImgHelper(this HtmlHelper helper, string src, string alt, object htmlAttributes)
        {
            var tag = new TagBuilder("img");
            tag.MergeAttribute("src", src);
            tag.MergeAttribute("alt", alt);
            tag.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(tag.ToString(TagRenderMode.SelfClosing));
        }
    }
}