using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class AccountBUS
    {
        AccountDAL acc = new AccountDAL();
        public string getEmail(string cus_id)
        {
            acc.setAcc(cus_id);
            return acc.getEmail();
        }
    }
}
