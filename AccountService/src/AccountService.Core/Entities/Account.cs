using AccountService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public char AccountType { get; set; }
        public string CustomerID { get; set; } 
        public AccountStatus AccountStatus { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal AvaliableBalance { get; set; }
    } 
}
