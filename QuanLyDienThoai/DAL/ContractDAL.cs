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
        public void cancelContract()
        {
            var cancel_contract = db.CONTRACTs.First(p => p.ID_CONTRACT == contract.ID_CONTRACT);

            cancel_contract.STATUS = false;
            db.SaveChanges();

            db.Entry(cancel_contract).State = EntityState.Detached;
        }
        //
        public void setCONTRACT_bySimID(string sim_id)
        {
            this.contract.ID_SIM = sim_id;
        }
        //
        public void cancelContract_bySimID()
        {
            var cancel_contract = db.CONTRACTs.First(p => p.ID_SIM == contract.ID_SIM);

            cancel_contract.STATUS = false;
            db.SaveChanges();

            db.Entry(cancel_contract).State = EntityState.Detached;
        }
        public string getSimID()
        {
            return (from h in db.CONTRACTs
                    where h.ID_CONTRACT.Equals(contract.ID_CONTRACT)
                    select h.ID_SIM).FirstOrDefault();
        }
        //1 Hợp đồng chỉ có 1 SIM => KTra nếu SIM khóa thì hợp đồng đã bị hủy.
        
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
