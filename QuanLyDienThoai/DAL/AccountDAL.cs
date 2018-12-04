using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    class AccountDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        ACCOUNT acc = new ACCOUNT();
        public void setAcc(string id)
        {
            this.acc.ID_CUSTOMER = id;
        }
        public string getEmail()
        {
            var email = (from h in db.ACCOUNTs
                          where h.ID_CUSTOMER.Equals(acc.ID_CUSTOMER)
                          select h.EMAIL).SingleOrDefault();
            return (string)email;
        }
    }
}
