using QuanLyDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.BUS
{
    class CustomerBUS
    {
        CustomerDAL customer_dal = new CustomerDAL();
        public IEnumerable<CUSTOMER> GetAll()
        {
            return customer_dal.GetAll();
        }
        public void Create(string name, int identity,string job,string position,string address)
        {
            customer_dal.setCustomer(name, identity, job, position, address);
            customer_dal.Create();
        }

        public void Delete(string id)
        {
            customer_dal.setCustomer(id);
            customer_dal.Delete();
        }

        public void Update(string id,string name, int identity, string job, string position, string address)
        {
            customer_dal.setCustomer(id, name, identity, job, position, address);
            customer_dal.Update();
        }
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            return customer_dal.SearchByName(name);
        }
    }
}
