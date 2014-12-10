using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Ashx
{
    /// <summary>
    /// SearchHistoryRelic 的摘要说明
    /// </summary>
    public class SearchHistoryRelic : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string historyRelicTime = context.Request["RelicTimeToAshx"];
            string historyRelicThing = context.Request["RelicThingToAshx"];
            List<string> listParams = new List<string>();
            listParams.Add(historyRelicTime);
            listParams.Add(historyRelicThing);
            //判断是否为空
            if(historyRelicTime==string.Empty&&historyRelicThing==string.Empty)
            {
                return;
            }
            else
            {
                //开始查询
                BLL.CulturalRelicBLL searchRelic =new  BLL.CulturalRelicBLL();
                searchRelic.SelectResult(listParams);

            }
            
            


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}