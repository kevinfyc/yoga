using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;

namespace Server
{
    /// <summary>
    /// WSAdviser 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSAdviser : System.Web.Services.WebService
    {

        [WebMethod]
        public string Add(Adviser a)
        {
            YogaEntities ey = new YogaEntities();
            ey.AddToAdviser(a);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }

        [WebMethod]
        public Adviser[] Search(Adviser c, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Adviser where cc.Name.Contains(c.Name) && cc.Position.Contains(c.Position) select cc;
            if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
            if (c.UserId > 0) query = query.Where((cc) => cc.UserId == c.UserId);
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
        public string Update(Adviser c)
        {
            YogaEntities ey = new YogaEntities();
            Adviser cc = ey.Adviser.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("顾问为{0}的教练不存在", c.Id);
            cc.Position = c.Position;
            cc.Mobilephone = c.Mobilephone;
            cc.Name = c.Name;
            cc.UserId = c.UserId;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            Adviser cc = ey.Adviser.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("顾问为{0}的教练不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
    }
}
