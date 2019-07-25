using System;
using System.Collections.Generic;
using Hangfire;
using Hangfire.SqlServer;
using Hangfire.Storage;
using System.Data.SqlClient;
using System.Data.Common;
using System.Net.Http;
using System.Threading.Tasks;
namespace SPReportScheduler
{
    class Program
    {
        static string theConnection = "Data Source=db101;Initial Catalog=spReportScheduler;User ID=poprocksuser; Password=rock#roll";
        static void Main(string[] args)
        {

            GlobalConfiguration.Configuration
            .UseSqlServerStorage(theConnection);

            var jobStorage = new Hangfire.SqlServer.SqlServerStorage(theConnection, new Hangfire.SqlServer.SqlServerStorageOptions
            {
                PrepareSchemaIfNecessary = false
            });

            //GlobalConfiguration.Configuration.UseAutofacActivator(provider);
            RecurringJobManager manager = new RecurringJobManager(jobStorage);

            List<scheduledReports> theReports = GetReports();

            //*********Code to clear out jobs if needed*********//
            using (var connection = jobStorage.GetConnection())
            {
                foreach (var recurringJob in StorageConnectionExtensions.GetRecurringJobs(connection))
                {
                    RecurringJob.RemoveIfExists(recurringJob.Id);

                }
            }
            int jobid = 0;
            foreach (scheduledReports sr in theReports)
            {
                RecurringJob.AddOrUpdate("reportjob_" + jobid.ToString(),() => sendReport(sr.apiCalls,sr.description,sr.emailRecipients), sr.cron);
                jobid++;
            }

            //foreach (scheduledReports sr in theReports)
            //{
            //    sendReport(sr.apiCalls, sr.description, sr.emailRecipients).Wait();

            //}

            GlobalConfiguration.Configuration.UseSqlServerStorage(theConnection);

            using (var server = new BackgroundJobServer())
            {
                Console.WriteLine("Hangfire Server started. Press any key to exit...");
                Console.ReadKey();
            }
        }
        public static async Task sendReport(string apis, string emailsubject, string recipients)
        {
            string htmlall = "";
           string[] apicalls = System.Text.RegularExpressions.Regex.Split(apis, ",");

            foreach (string  apicall in apicalls)
            {
                string content = await Callreportapi(apicall);
                htmlall += content;
            }
            Sendemail(emailsubject, recipients, htmlall);
        }

        public static bool Sendemail(string emailsubject, string recipients, string emailbody)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://apiprod.screenplaycloud.com");
                    var content = new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("sender", "Tech@kipany.com"),

                    new KeyValuePair<string, string>("senderName", "Tech"),
                    new KeyValuePair<string, string>("emailTo", recipients),
                    new KeyValuePair<string, string>("emailCC", ""),
                    new KeyValuePair<string, string>("subject", emailsubject),
                    new KeyValuePair<string, string>("attachement", ""),
                    new KeyValuePair<string, string>("body", emailbody)
                    });

                    var response = client.PostAsync("/api/email/send", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch {
                return false;
                    }
        }
        static public async Task<string> Callreportapi(string uri)
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return content;

        }
        public static List<scheduledReports> GetReports()
        {



            List<scheduledReports> srs = new List<scheduledReports>();






            SqlConnection conn = new SqlConnection(theConnection);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.CommandText = "Select * from scheduledReports where Active=1";

                cmd.Connection = conn;
                cmd.Connection.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    scheduledReports srep = new scheduledReports();

                    srep.description = dr["srTitle"].ToString();
                    srep.emailRecipients = dr["srEmails"].ToString();
                    srep.cron = dr["srCron"].ToString();
                    srep.apiCalls = dr["srAPIcalls"].ToString();
                    srs.Add(srep);
                }
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return srs;
        }

    }
}
