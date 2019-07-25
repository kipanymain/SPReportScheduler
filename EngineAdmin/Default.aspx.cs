using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EngineAdmin
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (RevenueConnectEntities rce = new RevenueConnectEntities())
            {
                DateTime qdt = DateTime.Now.AddHours(-1);

                var opencounts = rce.ContactRecords.Where(a => a.DispositionCode == "COMPLETE").Count();
                var partialcounts = rce.ContactRecords.Where(a => (a.DispositionCode == "PROFILE" && a.CallStartDateTime < qdt)).Count();
                var sendnewcounts = rce.QualifiedLeadSegments.Where(a => a.ContactSegmentStatus == "SENDNEW").Count();
                var sendagedcounts = rce.QualifiedLeadSegments.Where(a => a.ContactSegmentStatus == "SEND").Count();

                RadRadialCompletes.Pointer.Value = opencounts;
                Labelcomplete.Text = "Count: " + opencounts.ToString();
                RadRadialPartials.Pointer.Value = partialcounts;
                Labelpartial.Text = "Count: " + partialcounts.ToString();
                RadRadialSendnew.Pointer.Value = sendnewcounts;
                Labelsendnew.Text = "Count: " + sendnewcounts.ToString();

                RadRadialAged.Pointer.Value = sendagedcounts;
                Labelaged.Text = "Count: " + sendagedcounts.ToString();

                int rcount = 1;

                DataSet ds = new DataSet("Bookstore");
                DataTable dt = new DataTable("Products");
                dt.Columns.Add("Id", Type.GetType("System.Int32"));
                dt.Columns.Add("Name", Type.GetType("System.String"));
                dt.Columns.Add("Count", Type.GetType("System.Double"));
                var quecounts = rce.QualifiedLeadSegments.GroupBy(p => p.ContactSegmentStatus).Select(g => new { name = g.Key, count = g.Count() }).Where(w=> w.name.Contains("SEND_"));
                foreach (var rec in quecounts)
                {
                    dt.Rows.Add(rcount, rec.name, rec.count);

                    rcount++;
                }
                ds.Tables.Add(dt);
                RadHtmlChart1.DataSource = ds;
                RadHtmlChart1.DataBind();

            }
        }
    }
}