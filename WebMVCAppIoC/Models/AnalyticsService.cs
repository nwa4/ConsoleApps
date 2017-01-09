using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCAppIoC.Models
{
    public class AnalyticsService : IAnalyticsService
    {
        public string Code { get { return "Tracking You!"; } }
    }
}