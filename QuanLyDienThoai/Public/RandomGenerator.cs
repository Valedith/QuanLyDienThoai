using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.Public
{
    class RandomGenerator
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
        public static int RandomInteger(int min,int max)
        {
            return random.Next(min, max);
        }
        public TimeSpan RandomTimeSpan()
        {
            Random random = new Random();
            TimeSpan start = TimeSpan.FromHours(0);
            TimeSpan end = TimeSpan.FromHours(24);
            int maxMinutes = (int)((end - start).TotalMinutes);
            int minutes = random.Next(maxMinutes);
                return start.Add(TimeSpan.FromMinutes(minutes));
        }
    }
}
