using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;

namespace Server
{
    /// <summary>
    /// Summary description for WSRack
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSRack : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(Rack a)
        {
            YogaEntities ey = new YogaEntities();
            ey.AddToRack(a);
            return ey.SaveChanges() == 1 ? a.Id : -1;
        }

        [WebMethod]
        public Rack[] Search(Rack c, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Rack where cc.RackNo.Contains(c.RackNo) select cc;
            //if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
            if (c.RenterId > 0) query = query.Where((cc) => cc.RenterId == c.RenterId);
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
        public Rack[] GetEmpty()
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Rack where cc.RenterId==null || cc.RentExpire <= DateTime.Now select cc;
            return query.OrderBy((cc) => cc.Id).ToArray();
        }
        [WebMethod]
        public string Update(Rack c, DateTime start, DateTime end)
        {
            YogaEntities ey = new YogaEntities();
            Rack cc = ey.Rack.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("编号为{0}的柜子不存在", c.Id);
            cc.RackNo = c.RackNo;
            cc.RentDate = start;
            cc.RentExpire = end;
            cc.RenterId = c.RenterId>0?c.RenterId:null;
            cc.Remarks = c.Remarks;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            Rack cc = ey.Rack.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的柜子不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }

        public string GetRackNoById(int id)
        {
            YogaEntities ey = new YogaEntities();
            Rack m = ey.Rack.FirstOrDefault((mm) => mm.Id == id);
            return m == null ? "" : m.RackNo;
        }

        [WebMethod]
        public int GetIdByRackNo(string no)
        {
            YogaEntities ey = new YogaEntities();
            Rack m = ey.Rack.FirstOrDefault((mm) => mm.RackNo == no);
            return m == null ? -1 : m.Id;
        }
    }
}
