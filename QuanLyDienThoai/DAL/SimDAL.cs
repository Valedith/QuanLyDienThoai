using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    public class SimDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        SIM sim = new SIM();
        public void setSim(string id)
        {
            this.sim.ID_SIM = id;
        }
        public void setSim(string id,string cus_id,int phonenumber,bool status)
        {
            this.sim.ID_SIM = id;
            this.sim.PHONENUMBER = phonenumber;
            this.sim.ID_CUSTOMER = cus_id;
            this.sim.STATUS = status;
        }
        public void setSim(string cus_id,int phonenumber, bool status)
        {
            this.sim.ID_CUSTOMER = cus_id;
            this.sim.PHONENUMBER = phonenumber;
            this.sim.STATUS = status;
        }
        public IEnumerable<SIM> GetAll()
        {
            List<SIM> sim = db.SIMs.ToList();
            return sim;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "S0";

            while (db.SIMs.Any(c => c.ID_SIM == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "s";
            }
            sim.ID_SIM = id_str + numeric_value.ToString();


            db.SIMs.Add(sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            db.SIMs.Remove(delete_sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            edited_sim.ID_CUSTOMER = sim.ID_CUSTOMER;
            edited_sim.PHONENUMBER = sim.PHONENUMBER;
            edited_sim.STATUS = sim.STATUS;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }
    }
}
