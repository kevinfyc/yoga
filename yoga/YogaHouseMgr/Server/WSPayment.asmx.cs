using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;

namespace Server
{
    /// <summary>
    /// Summary description for WSPayment
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPayment : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(Payment a)
        {
            YogaEntities ey = new YogaEntities();
            ey.AddToPayment(a);
            return ey.SaveChanges() == 1 ? a.Id : -1;
        }

        [WebMethod]
        public Payment[] Search(Payment c, DateTime dateStart, DateTime dateEnd, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Payment where cc.Date >= dateStart && cc.Date <= dateEnd select cc;
            if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
            if (c.GoodsId > 0) query = query.Where((cc) => cc.GoodsId == c.GoodsId);
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
        [WebMethod]
        public string Update(Payment c)
        {
            YogaEntities ey = new YogaEntities();
            Payment cc = ey.Payment.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("顾问为{0}的教练不存在", c.Id);
            cc.Money = c.Money;
            cc.Date = c.Date;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            Payment cc = ey.Payment.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的付款单不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
    }
}
