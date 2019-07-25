using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.Common;
using Hangfire.SqlServer;
using Hangfire.Storage;
using System.Configuration;

[assembly: OwinStartup(typeof(HangfireDash.Startup))]

namespace HangfireDash
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            string cs = ConfigurationManager.ConnectionStrings["RevenueConnectEntities"].ConnectionString;

            var storage1 = new SqlServerStorage("Data Source=db101;Initial Catalog=spReportScheduler;User ID=poprocksuser; Password=rock#roll");
            app.UseHangfireDashboard("/hangfire",storage1);
            app.UseHangfireDashboard("/hangfire");
        }
    }
}
