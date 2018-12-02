using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    class DetailDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        DETAIL detail = new DETAIL();
        public void setDetail(int id)
        {
            this.detail.ID = id;
        }
        public void setDetail(int id, string id_sim, DateTime start, DateTime stop)
        {
            this.detail.ID = id;
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop)
        {
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop, int minutea7, int minutea23, int fare)
        {
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
            this.detail.MINUTE_AFTER7 = minutea7;
            this.detail.MINUTE_AFTER23 = minutea23;
            this.detail.FARE = fare;
        }
        public IEnumerable<DETAIL> GetAll()
        {
            List<DETAIL> detail = db.DETAILs.ToList();
            return detail;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.DETAILs.Any(c => c.ID == numeric_value))
            {
                numeric_value++;
            }
            detail.ID = numeric_value;


            db.DETAILs.Add(detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_detail = db.DETAILs.First(p => p.ID == detail.ID);

            db.DETAILs.Remove(delete_detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_detail = db.DETAILs.First(p => p.ID == detail.ID);

            edited_detail.ID_SIM = detail.ID_SIM;
            edited_detail.TIME_START = detail.TIME_START;
            edited_detail.TIME_STOP = detail.TIME_START;
            edited_detail.MINUTE_AFTER7 = detail.MINUTE_AFTER7;
            edited_detail.MINUTE_AFTER23 = detail.MINUTE_AFTER23;
            edited_detail.FARE = detail.FARE;

            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public IEnumerable<DETAIL> SearchByIDSIM(string id)
        {
            if (db.DETAILs.Any(c => c.ID_SIM.Contains(id)))
            {
                List<DETAIL> result = db.DETAILs.Where(c => c.ID_SIM.Contains(id)).ToList();
                return result;
            }
            return null;
        }
    }
}
