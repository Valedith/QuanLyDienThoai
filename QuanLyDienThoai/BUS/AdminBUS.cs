using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class AdminBUS
    {
        AdminDAL admin = new AdminDAL();
        public bool adminLogin(string username,string password)
        {
            admin.setAdmin(username, password);
            return admin.adminLogin();
        }
    }
}
