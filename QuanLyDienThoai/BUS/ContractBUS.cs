using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class ContractBUS
    {
        ContractDAL contract_dal = new ContractDAL();
        public IEnumerable<CONTRACT> GetAll()
        {
            return contract_dal.GetAll();
        }
        public string Create(string sim_id, DateTime date, int? fee)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(sim_id, date, fee);
                contract_dal.Create();
                    return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
            contract_dal.setCONTRACT(id);
            contract_dal.Delete();
            return "Xóa thành công !";
        }
        /*
        public IEnumerable<Minutetable> get_useMinuteList(string id)
        {
            contract_dal.setCONTRACT_cus(id);
            return contract_dal.get_useMinuteList();
        }
        */
        public string Update(string id,string sim_id, DateTime date, int? fee)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(id, sim_id, date, fee);
                contract_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
    }
}
