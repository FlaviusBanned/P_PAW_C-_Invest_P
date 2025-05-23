using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPaw
{
    public class Transaction
    {
        public Guid TransactionId { get; set; } = Guid.NewGuid(); 
        public string InvestorName { get; set; }
        public string PhoneNumber { get; set; }
        public string StockSymbol { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }

}
