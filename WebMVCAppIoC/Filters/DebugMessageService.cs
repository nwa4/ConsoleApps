using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVCAppIoC.Filter;

namespace WebMVCAppIoC.Filters
{
    public class DebugMessageService : IDebugMessageService
    {
        public string Message
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }
    }
}