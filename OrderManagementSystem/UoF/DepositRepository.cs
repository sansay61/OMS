using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Linq;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.UoF
{
    public class DepositRepository<T> : Repository<T> where T : IBaseEntity
    {

        private string buy = "select  e.* from \n" +
                            "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid)\n" +
                            "union \n" +
                            "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid))\n" +
                            "e ,instruments i,fix_securitytype fs,er_parties ep where i.id=fs.instrumentid and fs.short_name=e.securitytype\n" +
                            "and i.description='DEPOSIT' and ep.erid=e.id and e.exectype in (select value from fix_er_exectype where issubmit=1) and\n" +
                            "(\n" +
                            "(ep.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=1)\n" +
                            "or\n" +
                            "(ep.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=2)\n" +
                            ")";
        
        
        private string sell = "select  e.* from \n" +
                            "(select * from (select e2.* from er e1,er e2 where e1.execid=e2.execrefid)\n" +
                            "union \n" +
                            "select ei.* from er ei where ei.id not in (select e1.id from er e1,er e2 where e1.execid=e2.execrefid))\n" +
                            "e ,instruments i,fix_securitytype fs,er_parties ep where i.id=fs.instrumentid and fs.short_name=e.securitytype\n" +
                            "and i.description='DEPOSIT' and ep.erid=e.id and e.exectype in (select value from fix_er_exectype where issubmit=1) and\n" +
                            "(\n" +
                            "(ep.partyidrole=11 and exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=2)\n" +
                            "or\n" +
                            "(ep.partyidrole=11 and not exists (select blp_code from blp_dealers blpd where instr(ep.partyid,blpd.blp_code)>0) and e.side=1)\n" +
                            ")";

        

        public DepositRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public IList<T> GetSell()
        {
            return Session.CreateSQLQuery(sell).AddEntity(typeof(T)).List<T>();
        }

        public IList<T> GetBuy()
        {
            return Session.CreateSQLQuery(buy).AddEntity(typeof(T)).List<T>();
        }
    }
}