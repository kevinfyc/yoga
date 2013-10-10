using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;
namespace Server
{
    /// <summary>
    /// WSConsumption 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSConsumption : System.Web.Services.WebService
    {

        [WebMethod]
        public ConsumptionRecord[] Search(DateTime begin, DateTime end, string cardNo, string name, int operatorId, int gid, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ye = new YogaEntities();
            var query = from p in ye.ConsumptionRecord where p.Member.Name.Contains(name) 
                          && p.Member.CardNo.Contains(cardNo)  && p.Date >= begin && p.Date <= end select p;
            if (operatorId > 0) query = query.Where((p) => p.UserId == operatorId);
            if (gid > 0) query = query.Where((p) => p.GoodsId == gid);
            totalPages = (int)Math.Ceiling(query.Count() * 1.0 / pageSize);
            if (totalPages < 1)
            {
                page = 0;
                return null;
            }
            if (page == -1 || page > totalPages) page = totalPages;
            else if (page < 1) page = 1;
            return query.OrderBy((cc) => cc.Id).Skip((page - 1) * pageSize).Take(pageSize).ToArray();
        }
    }
}
