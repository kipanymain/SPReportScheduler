using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EngineAdmin
{
    public partial class campaigns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (RevenueConnectEntities rce = new RevenueConnectEntities())
            {
                DateTime qdt = DateTime.Now.AddHours(-1);

                int rcount = 1;

                int acceptedcount;
                int rejectedcount;
                int unknowncount;
                int limitcount;
                int queuedcount;


                DataSet ds = new DataSet("Campaigns");
                DataTable dt = new DataTable("Counts");
                dt.Columns.Add("Id", Type.GetType("System.String"));
                dt.Columns.Add("AcceptedCount", Type.GetType("System.Double"));
                dt.Columns.Add("RejectedCount", Type.GetType("System.Double"));
                dt.Columns.Add("UnknownCount", Type.GetType("System.Double"));
                dt.Columns.Add("LimitCount", Type.GetType("System.Double"));
                dt.Columns.Add("QueuedCount", Type.GetType("System.Double"));

                int curcamp = 0;
                string campname;
                int lastpros = 0;
                acceptedcount=0;
                rejectedcount=0;
                unknowncount=0;
                limitcount=0;
                queuedcount=0;
                
                var query = (from t in rce.QualifiedLeadSegments join c in rce.CAMPAIGNS on t.Campaign_ID equals c.CAMPAIGN_ID
                             where c.ACTIVE == true
                                 group t by new { t.Campaign_ID, t.ContactSegmentStatus }
                     into grp
                                 select new
                                 {
                                     grp.Key.Campaign_ID,
                                     grp.Key.ContactSegmentStatus,
                                     Quantity = grp.Count()
                                 }).OrderBy(grp=>grp.Campaign_ID).ToList();

                foreach (var rec in query)
                {
                    if (rec.Campaign_ID == curcamp || curcamp == 0)
                    {
                        if (curcamp==0)
                        {
                            curcamp = rec.Campaign_ID;

                        }
                        if (rec.ContactSegmentStatus.Contains("SEND"))
                        {
                            queuedcount += rec.Quantity;
                        }
                        else
                            switch (rec.ContactSegmentStatus)
                            {
                                case "ACCEPTED":
                                    acceptedcount += rec.Quantity;
                                    break;
                                case "REJECTED":
                                    rejectedcount += rec.Quantity;
                                    break;
                                case "UNKNOWN":
                                    unknowncount += rec.Quantity;
                                    break;
                                case "LIMIT":
                                    limitcount += rec.Quantity;
                                    break;
                            }

                    }
                    else
                    {
                        if (curcamp!=0)
                        {
                            string campn = rce.CAMPAIGNS.Where(c=> c.CAMPAIGN_ID == curcamp).FirstOrDefault().NAME;
                            dt.Rows.Add(campn + "(" + curcamp + ")", acceptedcount,rejectedcount,unknowncount,limitcount,queuedcount);
                            lastpros = curcamp;
                            curcamp = rec.Campaign_ID;
                            acceptedcount = 0;
                            rejectedcount = 0;
                            unknowncount = 0;
                            limitcount = 0;
                            queuedcount = 0;
                            if (rec.ContactSegmentStatus.Contains("SEND"))
                            {
                                queuedcount += rec.Quantity;
                            }
                            else
                                switch (rec.ContactSegmentStatus)
                                {
                                    case "ACCEPTED":
                                        acceptedcount += rec.Quantity;
                                        break;
                                    case "REJECTED":
                                        rejectedcount += rec.Quantity;
                                        break;
                                    case "UNKNOWN":
                                        unknowncount += rec.Quantity;
                                        break;
                                    case "LIMIT":
                                        limitcount += rec.Quantity;
                                        break;
                                }

                        }

                        }
                    }
                    if (lastpros != curcamp)
                    {
                    string campn = rce.CAMPAIGNS.Where(c => c.CAMPAIGN_ID == curcamp).FirstOrDefault().NAME;
                    dt.Rows.Add(campn + "(" + curcamp + ")", acceptedcount, rejectedcount, unknowncount, limitcount, queuedcount);


                    }

                ds.Tables.Add(dt);
                RadHtmlChart1.DataSource = ds;
                RadHtmlChart1.DataBind();
                }
            }
        }
    }
