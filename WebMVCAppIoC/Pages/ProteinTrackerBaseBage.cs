using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCAppIoC.Models;

namespace WebMVCAppIoC.Pages
{
    public class ProteinTrackerBaseBage : WebViewPage
    {
        [Dependency]
        public IAnalyticsService AnalyticsService { get; set; }
        public override void Execute()
        {
            
        }
    }
}