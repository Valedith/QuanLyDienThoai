using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    public class ContractDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        CONTRACT contract = new CONTRACT();
        public void setCONTRACT(String sim_id,DateTime date,int? fee)
        {
            this.contract.ID_SIM = sim_id;
            this.contract.FEE = fee;
            this.contract.DATEREGISTER = date;
        }
        public void setCONTRACT(string id)
        {
            this.contract.ID_CONTRACT = id;
        }
        public void setCONTRACT(string id, string sim_id,DateTime date, int? fee)
        {
            this.contract.ID_CONTRACT = id;
            this.contract.ID_SIM = sim_id;
            this.contract.FEE = fee;
            this.contract.DATEREGISTER = date;
        }
        public IEnumerable<CONTRACT> GetAll()
        {
            List<CONTRACT> contract = db.CONTRACTs.ToList();
            return contract;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "CT0";

            while (db.CONTRACTs.Any(c => c.ID_CONTRACT == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "CT";
            }
            contract.ID_CONTRACT = id_str + numeric_value.ToString();


            db.CONTRACTs.Add(contract);
            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_contract = db.CONTRACTs.First(p => p.ID_CONTRACT == contract.ID_CONTRACT);

            db.CONTRACTs.Remove(delete_contract);
            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }
        /*
        public IEnumerable<Minutetable> get_useMinuteList()
        {
            var query = db.CONTRACTs
                 .Join(db.FAREs,
                       con => con.ID_SIM,
                       fa => fa.ID_SIM,
                       (con, fa) => new { con, fa })
                 .Join(db.SIMs,
                       com => com.con.ID_SIM,
                       sim => sim.ID_SIM,
                       (com, sim) => new { com, sim })
                 .Where(z => z.com.con.ID_CUSTOMER == contract.ID_CUSTOMER)
                 .Select(z => new Minutetable
                 {
                     ID_CUSTOMER = z.com.con.ID_CUSTOMER,
                     ID_SIM = (int)z.com.con.ID_SIM,
                     TIME_STARTA7 = z.com.fa.TIME_STARTA7,
                     TIME_STARTB7 = z.com.fa.TIME_STARTB7,
                     TIME_STOPA23 = z.com.fa.TIME_STOPA23,
                     TIME_STOPB23 = z.com.fa.TIME_STOPB23
                 });
            return query.ToList();            
        }
        */
        public void Update()
        {
            var edited_contract = db.CONTRACTs.First(p => p.ID_CONTRACT == contract.ID_CONTRACT);

            edited_contract.ID_SIM = contract.ID_SIM;
            edited_contract.FEE = contract.FEE;
            edited_contract.DATEREGISTER = contract.DATEREGISTER;

            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }
    }
}
