using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    class FareDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        FARE fare = new FARE();
        public void setFare(string id, int fare1, TimeSpan start, TimeSpan stop)
        {
            this.fare.ID_FARE = id;
            this.fare.FARE1 = fare1;
            this.fare.TIME_START = start;
            this.fare.TIME_STOP = stop;
        }
        public void setFare(string id, TimeSpan start, TimeSpan stop)
        {
            this.fare.ID_FARE = id;
            this.fare.TIME_START = start;
            this.fare.TIME_STOP = stop;
        }
        public IEnumerable<FARE> GetAll()
        {
            List<FARE> fare = db.FAREs.ToList();
            return fare;
        }
        public TimeSpan getbeginTime(string id)
        {
            return (TimeSpan)db.FAREs.Where(c => c.ID_FARE == id).Select(c => c.TIME_START).SingleOrDefault();
        }
        public int getFare1(string id)
        {
            return (int)db.FAREs.Where(c => c.ID_FARE == id).Select(c => c.FARE1).SingleOrDefault();
        }
        public void Update()
        {
            var edited_fare = db.FAREs.First(p => p.ID_FARE == fare.ID_FARE);

            edited_fare.FARE1 = fare.FARE1;
            edited_fare.TIME_START = fare.TIME_START;
            edited_fare.TIME_STOP = fare.TIME_STOP;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
        public void Update_rest()
        {
            var edited_fare = db.FAREs.First(p => p.ID_FARE == fare.ID_FARE);

            edited_fare.TIME_START = fare.TIME_START;
            edited_fare.TIME_STOP = fare.TIME_STOP;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
        
    }
}
