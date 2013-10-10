using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;
using System.IO;
namespace Server
{
    /// <summary>
    /// WSMemeber 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WSMemeber : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddMember(Member m,byte[] picData)
        {
            YogaEntities ye = new YogaEntities();
            var mmm = ye.Member.FirstOrDefault((mm) =>mm.CardNo == m.CardNo);
            if (mmm != null) return -2;//已经存在卡号
            ye.AddToMember(m);
            int id = ye.SaveChanges()==1 ? m.Id : -1;
            if (id > 0&& picData!=null)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Server.MapPath(string.Format("Images/{0}.jpg", m.Id)), FileMode.Create, FileAccess.Write);
                    fs.Write(picData, 0, picData.Length);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            return id;
        }

        [WebMethod]
        public string GetCardNoById(int id)
        {
            YogaEntities ey = new YogaEntities();
            Member m = ey.Member.FirstOrDefault((mm) => mm.Id == id);
            return m == null ? "" : m.CardNo;
        }

        [WebMethod]
        public int GetIdByCardNo(string no)
        {
            YogaEntities ey = new YogaEntities();
            Member m = ey.Member.FirstOrDefault((mm) => mm.CardNo == no);
            return m==null ?  -1 : m.Id;
        }

        [WebMethod]
        public int PotentialToMember(Member m, byte[] picData, int pid)
        {
            YogaEntities ey = new YogaEntities();
            PotentialMember cc = ey.PotentialMember.FirstOrDefault((ccc) => ccc.Id == pid);
            if (cc == null) return -1;
            m.AdviserId = cc.AdviserId;
            int id = AddMember(m,picData);
            if (id>0 )
            {
                ey.DeleteObject(cc);
                ey.SaveChanges();
            }
            return id;
        }

        [WebMethod]
        public Member[] Search(Member c, bool includeNULLAid, ref int page, int pageSize, out int totalPages)
        {
            YogaEntities ey = new YogaEntities();
            var query = from cc in ey.Member where cc.Name.Contains(c.Name) && cc.CardType.Contains(c.CardType)
                            && cc.Mobilephone.Contains(c.Mobilephone) && !cc.Remarks.EndsWith("===已删除===") select cc;
            if (!string.IsNullOrWhiteSpace(c.CardNo)) query = query.Where((cc) => c.CardNo == cc.CardNo);
            //if (c.Id > 0) query = query.Where((cc) => cc.Id == c.Id);
            if(c.CoachId.ToString().Length<1)query = query.Where((cc)=>cc.CoachId == null);
            else if(c.CoachId>0) query = query.Where((cc)=>cc.CoachId == c.CoachId);
            if (c.AdviserId.ToString().Length < 1) query = query.Where((cc) => cc.AdviserId == null);
            else if (c.AdviserId > 0 && includeNULLAid) query = query.Where((cc) => cc.AdviserId == c.AdviserId || cc.AdviserId == null);
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
        public string CoachAllot(Member c)
        {
            YogaEntities ey = new YogaEntities();
            Member cc = ey.Member.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", c.Id);
            cc.CoachId = c.CoachId;
            return ey.SaveChanges() == 1 ? string.Format("编号为{0}的用户已经成功分配给编号为{1}的教练", c.Id, c.CoachId) : "分配失败";
        }
        [WebMethod]
        public string CoachAllots(int[] mids,int cid)
        {
            YogaEntities ey = new YogaEntities();
            Member[] cc = ey.Member.Where((ccc) => mids.Contains(ccc.Id)).ToArray();
            if (cc == null || cc.Length<1) return "指定编号的会员不存在";
            foreach (var item in cc)
            {
                item.CoachId = cid;                
            }
            return ey.SaveChanges() == cc.Length ? string.Format("已经成功分配给编号为{0}的教练", cid) : "分配失败";
        }

        [WebMethod]
        public string Delete(int id)
        {
            YogaEntities ey = new YogaEntities();
            Member cc = ey.Member.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", id);
            if (cc.Remarks == null) cc.Remarks = "===已删除===";
            else if(cc.Remarks.Length<=991) cc.Remarks += "===已删除===";
            else cc.Remarks = cc.Remarks.Substring(0, 991) + "===已删除===";//防止直接加会超长1000
            return ey.SaveChanges() == 1 ? "成功" : "失败";
        }

        [WebMethod]
        public string GainScore(Member c, int score)
        {
            YogaEntities ey = new YogaEntities();
            Member cc = ey.Member.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", c.Id);
            cc.Score += score;
            return ey.SaveChanges() == 1 ? "积分获取成功" : "积分获取失败";
        }

        [WebMethod]
        public string ConsumptionScore(Member c, int score)
        {
            YogaEntities ey = new YogaEntities();
            Member cc = ey.Member.FirstOrDefault((ccc) => ccc.Id == c.Id);
            if (score * 30 > cc.Score) return "积分不足！";
            if (cc == null) return string.Format("编号为{0}的会员不存在", c.Id);
            cc.Score -= score * 30;
            return ey.SaveChanges() == 1 ? "积分消费成功" : "积分消费失败";
        }

        [WebMethod]
        public string Update(Member m, byte[] picData)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == m.Id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", m.Id);
            cc.IsTemp = m.IsTemp;
            cc.Mobilephone = m.Mobilephone;
            cc.Name = m.Name;
            cc.Nation = m.Nation;
            cc.People = m.People;
            //cc.Picture = m.Picture;
            cc.RegistDate = m.RegistDate;
            cc.Remarks = m.Remarks;
            //cc.Score = m.Score;
            cc.Telephone = m.Telephone;
            cc.TempTimes = m.TempTimes;
            cc.CardNo = m.CardNo;
            cc.CardRestMoney = m.CardRestMoney;
            cc.CardStartMoney = m.CardStartMoney;
            cc.CardType = m.CardType;
            cc.ContractNo = m.ContractNo;
            cc.Gender = m.Gender;
            cc.Birthday = m.Birthday;
            cc.Email = m.Email;

            bool result = ye.SaveChanges() == 1;
            if (result && picData != null)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Server.MapPath(string.Format("Images/{0}.jpg", m.Id)), FileMode.Create, FileAccess.Write);
                    fs.Write(picData, 0, picData.Length);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            return result?"更新成功":"更新失败";
        }
        [WebMethod]
        public string Change(Member m, byte[] picData)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == m.Id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", m.Id);
            cc.Mobilephone = m.Mobilephone;
            cc.Name = m.Name;
            cc.Nation = m.Nation;
            cc.People = m.People;
            //cc.Picture = m.Picture;
            cc.Remarks = m.Remarks;
            //cc.Score = m.Score;
            cc.Telephone = m.Telephone;
            cc.CardNo = m.CardNo;
            cc.Gender = m.Gender;

            bool result = ye.SaveChanges() == 1;
            if (result && picData != null)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(Server.MapPath(string.Format("Images/{0}.jpg", m.Id)), FileMode.Create, FileAccess.Write);
                    fs.Write(picData, 0, picData.Length);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            return result ? "转卡成功" : "转卡失败";
        }
        [WebMethod]
        public string AddExprire(int id,DateTime exprire,string remarks)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", id);
            if (cc.ExpireDate < exprire) cc.ExpireDate = exprire;
            cc.Remarks = remarks;
            return ye.SaveChanges() == 1? "延期成功" : "延期失败";
        }
        [WebMethod]
        public string Consumption(int id,double money,int gid,int uid)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", id);
            if (cc.CardRestMoney < money) return "余额不足";
            Goods g = ye.Goods.FirstOrDefault((gg) => gg.Id == gid);
            if (g == null) return string.Format("编号为{0}的商品不存在", gid);
            User u = ye.User.FirstOrDefault((uu) => uu.Id == uid);
            if (u == null) return string.Format("编号为{0}的操作员不存在", uid);
            cc.CardRestMoney -= money;
            cc.Score += (int)money;
            var cr = new ConsumptionRecord()
            {
                Date = DateTime.Now,
                MemberId = id,
                 MemberName = cc.Name,
                 GoodsId = gid,
                 GoodsName = g.Name,
                UserId = uid,
                Operater = u.Name
            };

            ye.AddToConsumptionRecord(cr);
            return ye.SaveChanges() == 2 ? "扣值成功" : "扣值失败";
        }
        [WebMethod]
        public string Prepaid(int id, double money,int uid)
        {
            YogaEntities ye = new YogaEntities();
            Member cc = ye.Member.FirstOrDefault((ccc) => ccc.Id == id);
            if (cc == null) return string.Format("编号为{0}的会员不存在", id);
            User u = ye.User.FirstOrDefault((uu) => uu.Id == uid);
            if (u == null) return string.Format("编号为{0}的操作员不存在", uid);
            cc.CardRestMoney += money;
            ye.AddToPrepaidRecord(new PrepaidRecord() 
            {
                 Date = DateTime.Now,
                  MemberId = id,
                   Money = money,
                    UserId = uid,
                 MemberName = cc.Name,
                 Operater = u.Name,
            });
            return ye.SaveChanges() == 2 ? "充值成功" : "充值失败";
        }
    }
}
