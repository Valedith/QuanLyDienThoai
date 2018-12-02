using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class FareBUS
    {
        FareDAL fare_dal = new FareDAL();
        public IEnumerable<FARE> GetAll()
        {
            return fare_dal.GetAll();
        }
        public TimeSpan getbeginTime(string id)
        {
            return fare_dal.getbeginTime(id);
        }
        public int getFare1(string id)
        {
            return fare_dal.getFare1(id);
        }
        public string Update(string id, int fare1, TimeSpan start, TimeSpan stop)
        {
            fare_dal.setFare(id, fare1, start, stop);
            fare_dal.Update();
            return "Đã lưu thay đổi !";
        }
        public void Update_rest(string id, TimeSpan start, TimeSpan stop)
        {
            fare_dal.setFare(id, start, stop);
            fare_dal.Update_rest();
        }
    }
}
