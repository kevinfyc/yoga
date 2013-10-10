using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;
namespace Server
{
    /// <summary>
    /// WSImport 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSImport : System.Web.Services.WebService
    {

        [WebMethod]
        public string Import(int mid,string name,bool isTemp,int rid)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == mid);
            if (cc == null) return string.Format("编号为{0}的会员不存在", mid);
            ImportRecord ir = new ImportRecord()
            {
                 Date = DateTime.Now,
                  IsTemp = isTemp,
                   MemberId = mid,
                    MemberName = name,
            };
            ye.AddToImportRecord(ir);
            if (ye.SaveChanges() != 1) return "进场失败";
            Rack r = ye.Rack.FirstOrDefault((rr) => rr.Id == rid && (rr.RenterId==null || rr.RentExpire<=DateTime.Now));
            if (r != null)
            {
                r.RentDate = DateTime.Now;
                r.RentExpire = r.RentDate.AddHours(8);
                r.RenterId = mid;
                ye.SaveChanges();
            }
            Member m = ye.Member.FirstOrDefault((rr) => rr.Id == ir.Member.Id);
            if (m == null)
                return "没有该会员";
            if (m.IsTemp && m.TempTimes > 0)
            {
                m.TempTimes -= 1;
                cc.JoneCount += 1;
                ye.SaveChanges();
                return "进场成功";
            }
            if (m.IsTemp && m.TempTimes <= 0)
            {
                return "次数不足";
            }
            cc.JoneCount += 1;
            ye.SaveChanges();
            return "进场成功";
        }

        [WebMethod]
        public ImportRecord[] Search(ImportRecord c,string cardNo,DateTime begin,DateTime end, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.ImportRecord where cc.MemberName.Contains(c.MemberName) && cc.Member.CardNo.Contains(cardNo) select cc;
            if (c.MemberId > 0) query = query.Where((cc) => cc.MemberId == c.MemberId);
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
        public string Clear()
        {
            YogaEntities ye = new YogaEntities();
            ye.ExecuteStoreCommand("delete ImportRecord");
            return ye.SaveChanges() == 0 ? "清场成功" : "清场失败";
        }
    }
}
