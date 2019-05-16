using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        string billId;
        int billPayment;

        public BillDTO(string billId, int billPayment)
        {
            this.billId = billId;
            this.billPayment = billPayment;
        }

        public string BillId { get => billId; set => billId = value; }
        public int BillPayment { get => billPayment; set => billPayment = value; }

    }
}
