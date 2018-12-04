using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class SimBUS
    {
        SimDAL sim_dal = new SimDAL();
        public IEnumerable<SIM> GetAll()
        {
            return sim_dal.GetAll();
        }
        public string Create(string id_cus,int phonenumber, bool status)
        {
            if (phonenumber.ToString().Length < 0 || phonenumber.ToString().Length > 11)
                return "Số điện thoại không hợp lệ";
            else
            {
                sim_dal.setSim(id_cus,phonenumber, status);
                sim_dal.Create();
                return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
                sim_dal.setSim(id);
                sim_dal.Delete();
                    return "Xóa thành công !";
        }

        public string Update(string id,string id_cus, int phonenumber, bool status)
        {
            if (phonenumber.ToString().Length < 0 || phonenumber.ToString().Length > 11)
                return "Số điện thoại không hợp lệ";
            else
            {
                sim_dal.setSim(id,id_cus, phonenumber, status);
                sim_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
        public string lockSim(string id)
        {
            sim_dal.setSim(id);
            sim_dal.lockSim();
            return "Khóa SIM thành cống !";
        }
        public bool checkifLocked(string id)
        {
            sim_dal.setSim(id);
            return sim_dal.checkifLocked();
        }
    }
}
