using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

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
            List<ModalHelper.CulturalRelicModal> listModal = new List<ModalHelper.CulturalRelicModal>();
            //判断是否为空
            if(listParams[0]!=string.Empty && string.IsNullOrEmpty(listParams[1]))
            {
                context.Response.Write("未选定");
                
            }
            else
            {
                //开始查询
                BLL.CulturalRelicBLL searchRelic =new  BLL.CulturalRelicBLL();
                listModal=searchRelic.SelectResult(listParams);
                var json = new JavaScriptSerializer();
                var obj=json.Serialize(listModal);
                context.Response.Write(obj);
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






















