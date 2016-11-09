using NHibernate;
using OrderManagementSystem.Areas.OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.UoF
{
    public class SecurityRepository
    {
        IRepository<TcrSide> tcrsideRepo;
        IRepository<FixSecurityidsource> fixSecurityIdSourceRepo;
        private UnitOfWork _unitOfWork;
        public SecurityRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
            tcrsideRepo = new Repository<TcrSide>(_unitOfWork);
            fixSecurityIdSourceRepo = new Repository<FixSecurityidsource>(_unitOfWork);
        }

        private string buyER = "select e.* \n"+
                                "from \n"+
                                "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid) \n"+
                                "union  \n"+
                                "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid)) \n"+
                                "e ,instruments i,fix_securitytype fs,er_parties ep where i.id=fs.instrumentid and fs.short_name=e.securitytype  \n"+
                                "and i.description='SECURITY' and ep.erid=e.id and e.exectype in (select value from fix_er_exectype where issubmit=1) and \n"+
                                "( \n"+
                                "(ep.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=1) \n"+
                                "or \n"+
                                "(ep.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=2) \n"+
                                ")";

        private string buyTCR = "select t1.* \n" +
                                "from tcr t1, tcr_sides ts,tcr_sides_parties tsp where  \n" +
                                "t1.id=(select id from tcr t2 where transacttime=(select max(transacttime) from tcr t3 where  \n" +
                                "t3.secondarytradereportid=t1.secondarytradereportid) and t1.secondarytradereportid=t2.secondarytradereportid) \n" +
                                "and t1.tradereporttype in (select value from fix_tcr_tradereporttype where issubmit=1) and t1.id=ts.tcrid and  \n" +
                                "ts.id= tsp.tcr_sideid and ( \n" +
                                "(tsp.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(tsp.partyid,blpd.blp_code)>0) and ts.side=1) or \n" +
                                "(tsp.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(tsp.partyid,blpd.blp_code)>0) and ts.side=2)) \n";


        private string sellER = "select e.* \n" +
                                "from \n" +
                                "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid) \n" +
                                "union  \n" +
                                "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid)) \n" +
                                "e ,instruments i,fix_securitytype fs,er_parties ep where i.id=fs.instrumentid and fs.short_name=e.securitytype  \n" +
                                "and i.description='SECURITY' and ep.erid=e.id and e.exectype in (select value from fix_er_exectype where issubmit=1) and \n" +
                                "( \n" +
                                "(ep.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=2) \n" +
                                "or \n" +
                                "(ep.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=1) \n" +
                                ")";

        private string sellTCR = "select t1.* \n" +
                                "from tcr t1, tcr_sides ts,tcr_sides_parties tsp where  \n" +
                                "t1.id=(select id from tcr t2 where transacttime=(select max(transacttime) from tcr t3 where  \n" +
                                "t3.secondarytradereportid=t1.secondarytradereportid) and t1.secondarytradereportid=t2.secondarytradereportid) \n" +
                                "and t1.tradereporttype in (select value from fix_tcr_tradereporttype where issubmit=1) and t1.id=ts.tcrid and  \n" +
                                "ts.id= tsp.tcr_sideid and ( \n" +
                                "(tsp.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(tsp.partyid,blpd.blp_code)>0) and ts.side=2) or \n" +
                                "(tsp.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(tsp.partyid,blpd.blp_code)>0) and ts.side=1)) \n";

        protected ISession Session { get { return _unitOfWork.Session; } }
        public List<OrderManagementSystem.Areas.OMS.Models.Security> GetSell()
        {
            return Get(false);
        }

        public List<OrderManagementSystem.Areas.OMS.Models.Security> GetBuy()
        {
            return Get(true);
        }

        public List<OrderManagementSystem.Areas.OMS.Models.Security> Get(bool getbuy)
        {
            string erstring = buyER;
            string tcrstring = buyTCR;
            if (!getbuy)
            {
                erstring = sellER;
                tcrstring = sellTCR;
            }
            List<OrderManagementSystem.Areas.OMS.Models.Security> secs = new List<Areas.OMS.Models.Security>();
            IList<Er> er = Session.CreateSQLQuery(erstring).AddEntity(typeof(Er)).List<Er>();
            IList<Tcr> tcr = Session.CreateSQLQuery(tcrstring).AddEntity(typeof(Tcr)).List<Tcr>();
            OrderManagementSystem.Areas.OMS.Models.Security tempitem;
            foreach (var item in er)
            {
                tempitem = new Areas.OMS.Models.Security();
                tempitem.TradeDate = item.Tradedate;
                tempitem.SettlDate=item.Settldate;
                tempitem.MaturityDate=item.Maturitydate;
                tempitem.Price=item.Lastpx;
                tempitem.Nominal=item.Lastqty;
                tempitem.SecurityID=item.Securityid;
                tempitem.SecurityIDSource = fixSecurityIdSourceRepo.GetAll().Where(c => c.Value == item.Securityidsource).First().Description;
                tempitem.Yield=item.Yield;
                tempitem.Currency=item.Currency;
                tempitem.GrosstradeAmt=item.Grosstradeamt;
                tempitem.AccruedInterestAmt=item.Accruedinterestamount;
                tempitem.NetMoney=item.Netmoney;
                tempitem.Couponrate=item.Couponrate;
                tempitem.SecurityType=item.Securitytype;
                secs.Add(tempitem);
            }
            TcrSide tcrside=new TcrSide();
            foreach (var item in tcr)
            {
                tempitem = new Areas.OMS.Models.Security();
                tempitem.TradeDate = item.Tradedate;
                tempitem.SettlDate=item.Settldate;
                tempitem.MaturityDate=item.Maturitydate;
                tempitem.Price=item.Lastpx;
                tempitem.Nominal=item.Lastqty;
                tempitem.SecurityID=item.Securityid;
                tempitem.SecurityIDSource = fixSecurityIdSourceRepo.GetAll().Where(c => c.Value == item.Securityidsource).First().Description;
                tempitem.Yield=item.Yield;
                tcrside=tcrsideRepo.GetAll().Where(c=>c.Tcrid==item.Id).First();
                tempitem.Currency=tcrside.Currency;
                tempitem.GrosstradeAmt=tcrside.Grosstradeamt;
                tempitem.AccruedInterestAmt=tcrside.Accruedinterestamt;
                tempitem.NetMoney=tcrside.Netmoney;
               //tempitem.Couponrate=tcrside.Couponrate;
                tempitem.SecurityType=item.Securitytype;
                secs.Add(tempitem);
            }
            return secs;
        }
    }
}