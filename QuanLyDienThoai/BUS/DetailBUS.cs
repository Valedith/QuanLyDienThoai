using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class DetailBUS
    {
        DetailDAL detail_dal = new DetailDAL();
        public IEnumerable<DETAIL> GetAll()
        {
            return detail_dal.GetAll();
        }
        public string Create(string id_sim, DateTime start, DateTime stop)
        {
            detail_dal.setDetail(id_sim, start, stop);
            detail_dal.Create();
            return "Thêm thành công !";
        }

        public string Delete(int id)
        {
            detail_dal.setDetail(id);
            detail_dal.Delete();
            return "Xóa thành công !";
        }
        public string Update(int id, string id_sim, DateTime start, DateTime stop)
        {
            detail_dal.setDetail(id, id_sim, start, stop);
            detail_dal.Update();
            return "Đã lưu thay đổi !";
        }
        public void Import(string id_sim, DateTime start, DateTime end, int mina7, int mina23, int fare)
        {
            detail_dal.setDetail(id_sim, start, end, mina7, mina23, fare);
            detail_dal.Create();
        }
        public void CountTimeNormalThreshold(TimeSpan limitedStartTime, TimeSpan limitedEndTime, DateTime yourStartTime, DateTime yourEndTime, ref int totalMin1, ref int totalMin2)
        {
            TimeSpan thresholdPeriod = limitedEndTime - limitedStartTime;
            TimeSpan yourPeriod = (yourEndTime - yourStartTime);
            TimeSpan firstDayPeriod = (limitedEndTime - yourStartTime.TimeOfDay);
            TimeSpan yourTotalDays = yourEndTime.Date - yourStartTime.Date;
            TimeSpan middleDaysPeriod = TimeSpan.FromTicks((yourTotalDays - new TimeSpan(1, 0, 0, 0)).Days * thresholdPeriod.Ticks);
            TimeSpan lastDayPeriod = new TimeSpan();
            if (yourEndTime.TimeOfDay > limitedStartTime)
            {
                lastDayPeriod = (limitedStartTime <= yourEndTime.TimeOfDay && yourEndTime.TimeOfDay < limitedEndTime) ? yourEndTime.TimeOfDay - limitedStartTime : thresholdPeriod;
            }

            if (yourStartTime.TimeOfDay >= limitedStartTime && yourStartTime.TimeOfDay < limitedEndTime) //Start Time on the first day
            {
                TimeSpan result = (firstDayPeriod + middleDaysPeriod + lastDayPeriod);
                totalMin1 = (int)Math.Truncate((firstDayPeriod + middleDaysPeriod + lastDayPeriod).TotalMinutes);
                totalMin2 = (int)Math.Truncate((yourPeriod - result).TotalMinutes);
            }
            else //Start time on another day
            {
                if (yourTotalDays.TotalDays <= 0)
                {
                    middleDaysPeriod = TimeSpan.FromTicks(yourTotalDays.Days * thresholdPeriod.Ticks);
                }
                TimeSpan result = middleDaysPeriod + lastDayPeriod;
                totalMin1 = (int)Math.Truncate(result.TotalMinutes);
                totalMin2 = (int)Math.Truncate((yourPeriod - result).TotalMinutes);
            }
        }
        public void CountTimes(TimeSpan limitedStartTime, TimeSpan limitedEndTime, DateTime yourStartTime, DateTime yourEndTime, ref int totalMin1, ref int totalMin2)
        {
            CountTimeNormalThreshold(TimeSpan.FromTicks(Math.Min(limitedStartTime.Ticks, limitedEndTime.Ticks)),
                                    TimeSpan.FromTicks(Math.Max(limitedStartTime.Ticks, limitedEndTime.Ticks)), yourStartTime, yourEndTime, ref totalMin1, ref totalMin2);
        }
        public IEnumerable<DETAIL> SearchByIDSIM(string id)
        {
            return detail_dal.SearchByIDSIM(id);
        }
    }
}
