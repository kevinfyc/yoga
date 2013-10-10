using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;
namespace Server
{
    /// <summary>
    /// WSCoach 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSCoach : System.Web.Services.WebService
    {

        [WebMethod]
        public string Add(Coach c)
        {
            YogaEntities ey = new YogaEntities();
            ey.AddToCoach(c);
            return ey.SaveChanges()==1?"成功":"失败";
        }
        [WebMethod]
        public Coach[] Search(Coach c,ref int page,int pageSize,out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Coach where cc.Name.Contains(c.Name) && cc.Mobilephone.Contains(c.Mobilephone) select cc;
            if (c.Id > 0) query = query.Where((cc) => cc.Id==c.Id);
            totalPages = (int)Math.Ceiling(query.Count()*1.0/pageSize);
            if (totalPages < 1)
            {
                page = 0;
                return null;
            }
            if (page == -1 || page>totalPages) page = totalPages;
            else if (page < 1) page = 1;
            return query.OrderBy((cc) => cc.Id ).Skip((page - 1) * pageSize).Take(pageSize).ToArray();
        }
        [WebMethod]
        public string Update(Coach c)
        {
            YogaEntities ey = new YogaEntities();
            Coach cc = ey.Coach.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("编号为{0}的教练不存在",c.Id);
            cc.IsPrivate = c.IsPrivate;
            cc.Mobilephone = c.Mobilephone;
            cc.Name = c.Name;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            Coach cc = ey.Coach.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的教练不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
    }
}
