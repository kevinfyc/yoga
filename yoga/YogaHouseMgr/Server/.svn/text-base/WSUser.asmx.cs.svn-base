using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;
namespace Server
{
    /// <summary>
    /// WSUser 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSUser : System.Web.Services.WebService
    {
        [WebMethod]
        public User Login(string userName,string pwd)
        {
            YogaEntities ye = new YogaEntities();
            User u = ye.User.FirstOrDefault((uu) => uu.Name == userName && pwd == uu.Password);
            if(u!=null)
                u.Password = "";
            return u;
        }

        [WebMethod]
        public User[] List()
        {
            YogaEntities ye = new YogaEntities();
            User[] us = ye.User.ToArray();
            foreach (var item in us)
            {
                item.Password = "";
            }
            return us;
        }

        [WebMethod]
        public int Add(User a)
        {
            YogaEntities ey = new YogaEntities();
            ey.AddToUser(a);
            return ey.SaveChanges() == 1 ? a.Id : -1;
        }

        [WebMethod]
        public User[] Search(User c, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.User where cc.Name.Contains(c.Name) select cc;
            if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
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
        public string Update(User c)
        {
            YogaEntities ey = new YogaEntities();
            User cc = ey.User.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("{0}不存在", c.Id);
            cc.Password = c.Password;
            cc.UserType = c.UserType;
            cc.Name = c.Name;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            User cc = ey.User.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("{0}不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
    }
}
