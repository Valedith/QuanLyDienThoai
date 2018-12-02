using QuanLyDienThoai.DAL;
using QuanLyDienThoai.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.DAL
{
    public class AdminDAL
    {
        QLYCUOCDT_DB db = new QLYCUOCDT_DB();
        ADMIN admin = new ADMIN();
        public void setAdmin(string username,string password)
        {
            this.admin.USERNAME = username;
            this.admin.PASSWORD = password;
        }
        public Boolean adminLogin()
        {
            //string hash_pass = MD5Hash.CreateMD5(admin.PASSWORD);
            var myUser = db.ADMINs.FirstOrDefault(u => u.USERNAME == admin.USERNAME && u.PASSWORD == admin.PASSWORD);
            if (myUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
