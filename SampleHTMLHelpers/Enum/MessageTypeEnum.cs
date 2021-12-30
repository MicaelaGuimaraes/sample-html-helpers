using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SampleHTMLHelpers.Enum
{
    public enum MessageTypeEnum
    {
        [Description("Information")]
        Information,
        [Description("Warning")]
        Warning,
        [Description("Error")]
        Error,
        [Description("Success")]
        Success,
        [Description("Default")]
        Default
    }
}