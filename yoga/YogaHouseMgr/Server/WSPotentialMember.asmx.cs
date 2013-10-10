using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server
{
    /// <summary>
    /// WSPotentialMember 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSPotentialMember : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(PotentialMember c)
        {
            YogaEntities ey = new YogaEntities();
            c.CreateTime = DateTime.Now;
            c.LastContact = DateTime.Now;
            ey.AddToPotentialMember(c);
            return ey.SaveChanges() == 1 ? c.Id:-1;
        }
        [WebMethod]
        public PotentialMember[] Search(PotentialMember c,bool includeNULLAid, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.PotentialMember where cc.Name.Contains(c.Name) select cc;
            if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
            if (c.AdviserId.ToString().Length < 1) query = query.Where((cc) => cc.AdviserId == null);
            else if (c.AdviserId > 0 && includeNULLAid) query = query.Where((cc) => cc.AdviserId == c.AdviserId || cc.AdviserId==null);
            else if (c.AdviserId > 0 && !includeNULLAid) query = query.Where((cc) => cc.AdviserId == c.AdviserId);

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
        public string Update(PotentialMember c)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember cc = ey.PotentialMember.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("编号为{0}的潜在客户不存在", c.Id);
            cc.AdviserId = c.AdviserId;
            cc.CustomerChannel = c.CustomerChannel;
            cc.Gender = c.Gender;
            cc.Mobilephone = c.Mobilephone;
            cc.Name = c.Name;
            cc.Remarks = c.Remarks;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Track(int pid)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember cc = ey.PotentialMember.FirstOrDefault((ccc) => ccc.Id == pid);
            if (cc == null) return string.Format("编号为{0}的潜在客户不存在", pid);
            cc.LastContact = DateTime.Now;
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember cc = ey.PotentialMember.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的潜在会员不存在", id);
            ey.DeleteObject(cc);
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }
        [WebMethod]
        public string Allots(int[] pids, int aid)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember[] cc = ey.PotentialMember.Where((ccc) => pids.Contains(ccc.Id)).ToArray();
            if (cc == null || cc.Length < 1) return "指定编号的潜在客户不存在";
            foreach (var item in cc)
            {
                item.AdviserId = aid;
            }
            return ey.SaveChanges() == cc.Length ? string.Format("已经成功分配给编号为{0}的顾问", aid) : "分配失败";
        }
        [WebMethod]
        public string DeleteBatch(int[] pids)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember[] cc = ey.PotentialMember.Where((ccc) => pids.Contains(ccc.Id)).ToArray();
            if (cc == null || cc.Length < 1) return "指定编号的潜在客户不存在";
            foreach (var item in cc)
            {
                ey.DeleteObject(item);
            }
            return ey.SaveChanges() == cc.Length ? "成功删除": "失败";
        }
    }
}
