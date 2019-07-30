using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.Common;
using Hangfire.SqlServer;
using Hangfire.Storage;
using System.Configuration;
[assembly: OwinStartupAttribute(typeof(EngineAdmin.Startup))]
namespace EngineAdmin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);

            //string cs = ConfigurationManager.ConnectionStrings["RevenueConnectEntities"].ConnectionString;

            var storage1 = new SqlServerStorage("Data Source = db101; Initial Catalog = spReportScheduler; User ID = poprocksuser; Password = rock#roll");
            //app.UseHangfireDashboard("/hangfire", new DashboardOptions(),storage1);
            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[] { new MyAuthorizationFilter() }
            },storage1);

        }
    }
}
