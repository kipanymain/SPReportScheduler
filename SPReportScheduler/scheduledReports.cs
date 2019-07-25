using System;
using System.Collections.Generic;
using System.Text;

namespace SPReportScheduler
{
    class scheduledReports
    {
        public string description { get; set; }
        public string cron { get; set; }
        public string emailRecipients { get; set; }
        public string apiCalls { get; set; }

    }
}
