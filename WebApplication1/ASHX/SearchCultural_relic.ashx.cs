using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalHelper.ASHX
{
    /// <summary>
    /// SearchCultural_relic 的摘要说明
    /// </summary>
    public class SearchCultural_relic : IHttpHandler
    {

        /// <summary>
        /// 查询并返回结果
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string dataTime = context.Request["DateTimeToAshx"];
            string culturalRelic = context.Request["culturalRelicToAshx"];
            List<ModalHelper.CulturalRelicModal> listModal;
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