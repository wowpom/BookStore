using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string PurchasePerson { get; set; }
        public string PurchaseAddress { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}