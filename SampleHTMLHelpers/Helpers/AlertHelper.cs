using SampleHTMLHelpers.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleHTMLHelpers.Helpers
{
    public static class AlertHelper
    {

        public static MvcHtmlString MessageAlert(this HtmlHelper helper, string msg, MessageTypeEnum? typeMessage)
        {
            return MessageAlert(helper, msg, typeMessage, null);
        }
        public static MvcHtmlString MessageAlert(this HtmlHelper helper, string msg, MessageTypeEnum? typeMessage,
                                           object htmlAttributes)
        {
            if (msg == null || String.IsNullOrEmpty(msg))
            {
                return MvcHtmlString.Empty;
            }
            return BuildMessageHelper(helper, msg, typeMessage, htmlAttributes);
        }

        private static MvcHtmlString BuildMessageHelper(this HtmlHelper helper, string MsgText, MessageTypeEnum? typeMessage, object attributes)
        {
            var ulMsg = new TagBuilder("div");

            switch (typeMessage)
            {
                case MessageTypeEnum.Information:
                    ulMsg.MergeAttribute("class", "alert alert-info alert-dismissible fade show");
                    break;
                case MessageTypeEnum.Error:
                    ulMsg.MergeAttribute("class", "alert alert-danger alert-dismissible fade show");
                    break;
                case MessageTypeEnum.Warning:
                    ulMsg.MergeAttribute("class", "alert alert-warning alert-dismissible fade show");
                    break;
                case MessageTypeEnum.Success:
                    ulMsg.MergeAttribute("class", "alert alert-success alert-dismissible fade show");
                    break;
            }

            if (typeMessage == null)
            {
                ulMsg.MergeAttribute("class", "alert alert-secondary alert-dismissible fade show");
            }

            ulMsg.MergeAttribute("role", "alert");
            ulMsg.MergeAttributes(new RouteValueDictionary(attributes));

            var sb = new StringBuilder();
            sb.AppendFormat("<p>{0}</p>", MsgText);
            sb.Append("<button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button>");
            ulMsg.InnerHtml = sb.ToString();
            return MvcHtmlString.Create(ulMsg.ToString(TagRenderMode.Normal));
        }
    }
}
