using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    class BillDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        BILL bill = new BILL();
        public void setBill(string id, string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.ID_BILL = id;
            this.bill.ID_SIM = id_sim;
            this.bill.DATE_EXPORT = date_ex;
            this.bill.DATE_CUT = date_cut;
            this.bill.POSTAGE = postage;
            this.bill.FARE = fare;
            this.bill.STATUS = status;
        }
        public void setBill(string id_sim, DateTime date_ex, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.ID_SIM = id_sim;
            this.bill.DATE_EXPORT = date_ex;
            this.bill.DATE_CUT = date_cut;
            this.bill.POSTAGE = postage;
            this.bill.FARE = fare;
            this.bill.STATUS = status;
        }
        public void setBill(string id)
        {
            this.bill.ID_BILL = id;
        }
        public IEnumerable<BILL> GetAll()
        {
            List<BILL> bill = db.BILLs.ToList();
            return bill;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "B0";

            while (db.BILLs.Any(c => c.ID_BILL == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "B";
            }
            bill.ID_BILL = id_str + numeric_value.ToString();

            db.BILLs.Add(bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);

            db.BILLs.Remove(delete_bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);

            edited_bill.ID_SIM = bill.ID_SIM;
            edited_bill.DATE_EXPORT = bill.DATE_EXPORT;
            edited_bill.DATE_CUT = bill.DATE_CUT;
            edited_bill.POSTAGE = bill.POSTAGE;
            edited_bill.FARE = bill.FARE;
            edited_bill.STATUS = bill.STATUS;

            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Pay()
        {
            var edited_bill = db.BILLs.First(p => p.ID_BILL == bill.ID_BILL);
            
            edited_bill.STATUS = true;

            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public IEnumerable<BILL> SearchByIDSIM(string id)
        {
            if (db.SIMs.Any(c => c.ID_SIM.Contains(id)))
            {
                List<BILL> result = db.BILLs.Where(c => c.ID_SIM.Contains(id)).ToList();
                return result;
            }
            return null;
        }
    }
}
