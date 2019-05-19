using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BillBLL
    {
        public List<BillDTO> GetAllBill()
        {
            BillDAL bdal = new BillDAL();
            return bdal.GetAllBill();
        }

        public List<BillDTO> GetAllBill(string bill_id)
        {
            BillDAL bdal = new BillDAL();
            return bdal.GetAllBill(bill_id);
        }
        public BillDTO GetBill(string id)
        {
            BillDAL bdal = new BillDAL();
            return bdal.GetBill(id);
        }

        public bool InsertBill(BillDTO bill)
        {
            BillDAL bdal = new BillDAL();
            return bdal.InsertBill(bill);
        }

        public bool InsertBill(string billId, int billPayment)
        {
            BillDAL bdal = new BillDAL();
            return bdal.InsertBill(billId, billPayment);
        }

        public bool UpdateBill(BillDTO bill)
        {
            BillDAL bdal = new BillDAL();
            return bdal.UpdateBill(bill);
        }
    }
}
