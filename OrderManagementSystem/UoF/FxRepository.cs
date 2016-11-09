using OrderManagementSystem.Areas.OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace OrderManagementSystem.UoF
{
    public class FxRepository
    {
        string nonswap =
            "select  e.* from  \n" +
            "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid) \n" +
            "union  \n" +
            "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid)) \n" +
            "e ,fix_securitytype fs where  fs.short_name=e.securitytype \n" +
            "and (e.securitytype='FXSPOT' or  e.securitytype='FXFWD') and e.exectype in (select value from fix_er_exectype where issubmit=1)";
        
        string swap =
            "select  e.* from  " +
            "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid) " +
            "union  " +
            "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid)) " +
            "e ,fix_securitytype fs where  fs.short_name=e.securitytype " +
            "and e.securitytype='FXSWAP' and e.exectype in (select value from fix_er_exectype where issubmit=1)";

        string swapLeg =
            "select  el.* from  " +
            "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid) " +
            "union  " +
            "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid)) " +
            "e ,fix_securitytype fs, er_legs el where  fs.short_name=e.securitytype " +
            "and e.securitytype='FXSWAP'  and el.erid=e.id and e.exectype in (select value from fix_er_exectype where issubmit=1)";
        
        private UnitOfWork _unitOfWork;
        IRepository<FixSecurityidsource> fixSecurityIdSourceRepo;
        IRepository<BlpDealer> dealersRepo;
        IRepository<ErParty> partiesRepo;
        protected ISession Session { get { return _unitOfWork.Session; } }
        public FxRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
            fixSecurityIdSourceRepo = new Repository<FixSecurityidsource>(_unitOfWork);
            partiesRepo = new Repository<ErParty>(_unitOfWork);
            dealersRepo = new Repository<BlpDealer>(_unitOfWork);
        }

        public List<OrderManagementSystem.Areas.OMS.Models.Fx> GetSell()
        {
            return GetList(false);
        }

        public List<OrderManagementSystem.Areas.OMS.Models.Fx> GetBuy()
        {
            return GetList(true);
        }

        public List<OrderManagementSystem.Areas.OMS.Models.Fx> GetList(bool getbuy)
        {
            string dbsqlqueryNonswap = nonswap;
            string dbsqlquerySwap = swap;
            string dbsqlquerySwapLeg = swapLeg;
            bool isRateStraight;

            List<OrderManagementSystem.Areas.OMS.Models.Fx> fxs = new List<Areas.OMS.Models.Fx>();
            IList<Er> er = Session.CreateSQLQuery(dbsqlqueryNonswap).AddEntity(typeof(Er)).List<Er>();
            string nbkrside;
            OrderManagementSystem.Areas.OMS.Models.Fx tempitem;
            foreach (var item in er)
            {
                nbkrside = GetNBKRSide(item);
                tempitem = new Areas.OMS.Models.Fx();
                tempitem.TradeDate = item.Tradedate;
                tempitem.SettlDate = item.Settldate;
                //(BUY)

                if ((nbkrside == "BUY" && item.Side == 1) || (nbkrside == "SELL" && item.Side == 2))
                {
                    tempitem.Currency = item.Currency;
                    tempitem.CurrencyAmt = item.Orderqty;
                    tempitem.SettlCurrency = item.Settlcurrency;
                    tempitem.SettlCurrencyAmt = item.Settlcurramt;
                }
                else
                {
                    tempitem.Currency = item.Settlcurrency;
                    tempitem.CurrencyAmt = item.Settlcurramt;
                    tempitem.SettlCurrency = item.Currency;
                    tempitem.SettlCurrencyAmt = item.Orderqty;
                }
                item.Symbol=item.Symbol.Trim();
                if (item.Symbol.IndexOf(tempitem.Currency) == 0)
                    tempitem.LastPx = 1.0/item.Lastpx;
                else tempitem.LastPx = item.Lastpx;
                tempitem.OrderID = item.Execid;
                tempitem.isFXSwap = false;
                fxs.Add(tempitem);
            }
            er = Session.CreateSQLQuery(dbsqlquerySwap).AddEntity(typeof(Er)).List<Er>();
            Er parentEr = null; 
            IList<ErLeg> erlegs = Session.CreateSQLQuery(dbsqlquerySwapLeg).AddEntity(typeof(ErLeg)).List<ErLeg>();
            ErLeg leg;
            foreach (var item in erlegs)
            {
                //looking for parent SWAP DEAL
                parentEr = er.Where(c => c.Id == item.Erid).First();
                //
                nbkrside = GetNBKRSide(parentEr);
                tempitem = new Areas.OMS.Models.Fx();
                tempitem.TradeDate = parentEr.Tradedate;
                tempitem.SettlDate = item.Legsettldate;
                if ((nbkrside == "BUY" && item.Legside == 1) || (nbkrside == "SELL" && item.Legside == 2))
                {
                    tempitem.Currency = item.Legcurrency;
                    tempitem.CurrencyAmt = item.Legqty;
                    tempitem.SettlCurrency = parentEr.Settlcurrency;
                    tempitem.SettlCurrencyAmt = item.Legcalculatedccylastqty;
                    tempitem.LastPx = item.Leglastpx;
                }
                else
                {
                    tempitem.Currency = parentEr.Settlcurrency;
                    tempitem.CurrencyAmt = item.Legcalculatedccylastqty;
                    tempitem.SettlCurrency = item.Legcurrency;
                    tempitem.SettlCurrencyAmt = item.Legqty;
                    tempitem.LastPx = item.Leglastpx;
                }
                item.Legsymbol = item.Legsymbol.Trim();
                if (item.Legsymbol.IndexOf(tempitem.Currency) == 0)
                    tempitem.LastPx = 1.0 / item.Leglastpx;
                else tempitem.LastPx = item.Leglastpx;

                tempitem.OrderID = parentEr.Execid;
                tempitem.isFXSwap = true;
                fxs.Add(tempitem);
            }
            return fxs;
        }

        private string GetNBKRSide(Er item)
        {
            foreach (var party in partiesRepo.GetAll().Where(c => c.Erid == item.Id && c.Partyidrole==11 ).ToList())
            {
                if (IsPartySellside(party))
                return "SELL";
            }
            return "BUY";
        }

        private bool IsPartySellside(ErParty party)
        {

            if (dealersRepo.GetAll().Where(c => party.Partyid.ToUpper().IndexOf(c.BlpCode.ToString().ToUpper())>=0)!= null)
                return false;
            return true;
        }
    }
}